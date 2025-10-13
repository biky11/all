import lgpio
from flask import Flask

app = Flask(__name__)

LED_PIN = 18
chip = lgpio.gpiochip_open(0)
lgpio.gpio_claim_output(chip, LED_PIN)

@app.route("/on")
def turn_on():
    lgpio.gpio_write(chip, LED_PIN, 1)
    return "LED turned ON"

@app.route("/off")
def turn_off():
    lgpio.gpio_write(chip, LED_PIN, 0)
    return "LED turned OFF"

@app.route("/")
def home():
    return "Raspberry Pi 5 Home Automation API"

if __name__ == "__main__":
    try:
        app.run(host="0.0.0.0", port=5000)
    except KeyboardInterrupt:
        pass
    finally:
        lgpio.gpiochip_close(chip)
