from gpiozero import LED, DistanceSensor
from time import sleep

led = LED(18)
sensor = DistanceSensor(echo=24, trigger=23, max_distance=2.0)

try:
    while True:
        distance_cm = sensor.distance * 100  # convert to cm
        print(f"Distance: {distance_cm:.2f} cm")
        
        if distance_cm <= 10:
            led.on()
            sleep(0.5)
            led.off()
            sleep(0.5)
        else:
            led.off()
            sleep(0.1)
except KeyboardInterrupt:
    print("Exiting.")
