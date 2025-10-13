from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
import lgpio
from time import sleep

# ---- GPIO Setup ----
LED_PIN = 18
chip = lgpio.gpiochip_open(0)
lgpio.gpio_claim_output(chip, LED_PIN)

# ---- Blink Function ----
def blink_led():
    for _ in range(5):
        lgpio.gpio_write(chip, LED_PIN, 1)
        sleep(0.5)
        lgpio.gpio_write(chip, LED_PIN, 0)
        sleep(0.5)

# ---- Telegram Bot Handlers ----
async def start(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Hello! Send /blink to blink the LED.")

async def blink(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Blinking LED!")
    blink_led()

async def unknown(update: Update, context: ContextTypes.DEFAULT_TYPE):
    await update.message.reply_text("Sorry, I didn't understand that command.")

# ---- Main ----
def main():
    TOKEN = "8203758858:AAEgB4dZ3n4964Q42sz5hxQbobDjxlg6mQE"

    app = ApplicationBuilder().token(TOKEN).build()

    app.add_handler(CommandHandler("start", start))
    app.add_handler(CommandHandler("blink", blink))

    print("Bot is running...")
    app.run_polling()

    lgpio.gpiochip_close(chip)

if __name__ == "__main__":
    main()
