import RPi.GPIO as GPIO
from mfrc522 import SimpleMFRC522
import time

reader = SimpleMFRC522()

try:
    # Ask user for data to write
    data = input("Enter data to write: ").strip()
    print("Now place your RFID tag near the reader to write...")
    
    while True:  # Corrected the case of 'while'
        reader.write(data)
        print("Data written to tag.")
        time.sleep(2)
        
except KeyboardInterrupt:
    print("\nProgram stopped by user.")
finally:
    GPIO.cleanup()
    print("GPIO cleanup done.")
