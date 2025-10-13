from mfrc522 import SimpleMFRC522

reader = SimpleMFRC522()
while True:
        
    try:
        print("Place your RFID tag near the reader")
        id, text = reader.read()
        print(f"RFID ID: {id}")
        print(f"Data on tag: {text}")
    finally:
        print("Cleaning up GPIO")
