import time
import board
import busio
import lgpio   # Modern GPIO library for Raspberry Pi 5
from adafruit_ads1x15.ads1115 import ADS1115
from adafruit_ads1x15.analog_in import AnalogIn
import matplotlib.pyplot as plt

# --- Setup GPIO using lgpio ---
CHIP = 0  # Default GPIO chip
TRIG = 23
ECHO = 24

chip = lgpio.gpiochip_open(CHIP)
lgpio.gpio_claim_output(chip, TRIG)
lgpio.gpio_claim_input(chip, ECHO)

# --- Setup I2C for ADS1115 ---
i2c = busio.I2C(board.SCL, board.SDA)
ads = ADS1115(i2c)
chan = AnalogIn(ads, 0)  # A0 channel

# --- Function to read ultrasonic distance ---
def read_ultrasonic_distance():
    lgpio.gpio_write(chip, TRIG, 0)
    time.sleep(0.05)

    lgpio.gpio_write(chip, TRIG, 1)
    time.sleep(0.00001)
    lgpio.gpio_write(chip, TRIG, 0)

    pulse_start = time.time()
    timeout = pulse_start + 0.02  # 20 ms timeout for safety

    # Wait for ECHO to go high
    while lgpio.gpio_read(chip, ECHO) == 0:
        pulse_start = time.time()
        if pulse_start > timeout:
            return None  # timeout

    # Wait for ECHO to go low
    while lgpio.gpio_read(chip, ECHO) == 1:
        pulse_end = time.time()
        if pulse_end - pulse_start > 0.03:  # safety timeout
            return None

    pulse_duration = pulse_end - pulse_start
    distance = pulse_duration * 34300 / 2  # cm
    return distance


# --- Main Program ---
try:
    distances = []
    adc_values = []

    print("Starting measurement... Press Ctrl+C to stop")

    for i in range(20):
        dist = read_ultrasonic_distance()
        adc_val = chan.value
        voltage = chan.voltage

        if dist is not None:
            print(f"Distance: {dist:.2f} cm | ADC: {adc_val} | Voltage: {voltage:.3f} V")
            distances.append(dist)
            adc_values.append(voltage)
        else:
            print("Timeout: no echo received")

        time.sleep(1)

    # --- Plot Graph ---
    plt.plot(distances, label="Ultrasonic Distance (cm)", color='blue', marker='o')
    plt.title("Ultrasonic Sensor + ADS1115 Readings (Pi 5)")
    plt.xlabel("Sample Number")
    plt.ylabel("Distance (cm)")
    plt.legend()
    plt.grid(True)
    plt.show()

except KeyboardInterrupt:
    print("\nMeasurement stopped by user")

finally:
    lgpio.gpiochip_close(chip)



#sudo apt update
#sudo apt install python3-lgpio python3-pip python3-matplotlib
#sudo pip3 install adafruit-circuitpython-ads1x15
