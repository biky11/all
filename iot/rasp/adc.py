import time
import matplotlib.pyplot as plt
from adafruit_ads1x15.analog_in import AnalogIn
import adafruit_ads1x15.ads1115 as ADS
import board
import busio

# Initialize I2C and ADS1115
i2c = busio.I2C(board.SCL, board.SDA)
ads = ADS.ADS1115(i2c)
chan = AnalogIn(ads, ADS.P0)  # Read from A0

# For live graph
plt.ion()
fig, ax = plt.subplots()
x_data = []
y_data = []
line, = ax.plot(x_data, y_data)
ax.set_title("Live Sensor Data (ADS1115)")
ax.set_xlabel("Time (s)")
ax.set_ylabel("Voltage (V)")

start_time = time.time()

try:
    while True:
        voltage = chan.voltage
        elapsed = time.time() - start_time

        x_data.append(elapsed)
        y_data.append(voltage)

        # Keep only last 100 readings for speed
        if len(x_data) > 100:
            x_data = x_data[-100:]
            y_data = y_data[-100:]

        line.set_xdata(x_data)
        line.set_ydata(y_data)
        ax.relim()
        ax.autoscale_view()

        plt.pause(0.05)

        print(f"Voltage: {voltage:.3f} V")
        time.sleep(0.1)

except KeyboardInterrupt:
    print("Stopped by user.")
