import time
import board
import busio
import RPi.GPIO as GPIO
from adafruit_ads1x15.ads1115 import ADS1115
from adafruit_ads1x15.analog_in import AnalogIn
import matplotlib.pyplot as plt

# --- Setup GPIO Pins for Ultrasonic ---
TRIG = 23
ECHO = 24

GPIO.setmode(GPIO.BCM)
GPIO.setup(TRIG, GPIO.OUT)
GPIO.setup(ECHO, GPIO.IN)

# --- Setup I2C for ADS1115 ---
i2c = busio.I2C(board.SCL, board.SDA)
ads = ADS1115(i2c)
chan = AnalogIn(ads, 0)  # Channel 0 (A0)

# --- Function to Read Ultrasonic Distance ---
def read_ultrasonic_distance():
    GPIO.output(TRIG, False)
    time.sleep(0.05)

    GPIO.output(TRIG, True)
    time.sleep(0.00001)
    GPIO.output(TRIG, False)

    # Wait for ECHO start
    while GPIO.input(ECHO) == 0:
        pulse_start = time.time()

    # Wait for ECHO end
    while GPIO.input(ECHO) == 1:
        pulse_end = time.time()

    pulse_duration = pulse_end - pulse_start
    distance = pulse_duration * 34300 / 2  # Speed of sound = 34300 cm/s
    return distance


# --- Main Program ---
try:
    distances = []
    adc_values = []

    print("Starting measurement... Press Ctrl+C to stop")

    for i in range(20):  # Take 20 readings
        dist = read_ultrasonic_distance()
        adc_val = chan.value
        voltage = chan.voltage

        print(f"Distance: {dist:.2f} cm | ADC: {adc_val} | Voltage: {voltage:.3f} V")

        distances.append(dist)
        adc_values.append(adc_val)
        time.sleep(1)

    # --- Plot Graph ---
    plt.plot(distances, label="Ultrasonic Distance (cm)", color='blue', marker='o')
    plt.title("Ultrasonic Sensor Distance Readings")
    plt.xlabel("Sample Number")
    plt.ylabel("Distance (cm)")
    plt.legend()
    plt.grid(True)
    plt.show()

except KeyboardInterrupt:
    print("Measurement stopped by user")

finally:
    GPIO.cleanup()


#sudo pip3 install adafruit-circuitpython-ads1x15
#sudo apt install python3-matplotlib
