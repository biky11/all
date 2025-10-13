from picamera2 import Picamera2
from time import sleep

picam2 = Picamera2()
picam2.start_preview()
sleep(5)
picam2.capture_file("/home/ancel/m1/c.jpeg")
picam2.stop_preview()
