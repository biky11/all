from flask import Flask
import RPi.GPIO as GPIO

LED_PIN = 18

GPIO.setmode(GPIO.BCM)
GPIO.setup(LED_PIN, GPIO.OUT)

app = Flask(__name__)

@app.route("/on")
def led_on():
    GPIO.output(LED_PIN, True)
    return "LED is ON"

@app.route("/off")
def led_off():
    GPIO.output(LED_PIN, False)
    return "LED is OFF"

@app.route("/")
def home():
    return "Raspberry Pi LED Controller"

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)
