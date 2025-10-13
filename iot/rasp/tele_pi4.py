from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
import RPi.GPIO as GPIO
from time import sleep

# ---- GPIO Setup ----
LED_PIN = 18
GPIO.setmode(GPIO.BCM)
GPIO.setup(LED_PIN, GPIO.OUT)

# ---- Blink Function ----
def blink_led():
    for _ in range(5):  # Blink 5 times
        GPIO.output(LED_PIN, True)
        sleep(0.5)
        GPIO.output(LED_PIN, False)
        sleep(0.5)

# ---- Telegram Bot Handlers ----
async def start(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Hello! Send /blink to blink the LED.")

async def blink(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Blinking LED!")
    blink_led()

async def unknown(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Sorry, I didn't understand that command.")

# ---- Main Bot Setup ----
def main():
    TOKEN = "YOUR_BOT_TOKEN_HERE"  # Replace with your actual Telegram bot token

    app = ApplicationBuilder().token(TOKEN).build()

    app.add_handler(CommandHandler("start", start))
    app.add_handler(CommandHandler("blink", blink))

    print("Bot is running...")
    app.run_polling()

    GPIO.cleanup()

if __name__ == "__main__":
    main()
