import tm1637
import time
from datetime import datetime

# Initialize TM1637 (CLK, DIO)
tm = tm1637.TM1637(clk=5, dio=4)


colon = True  # for blinking the colon

while True:
    # Get current time in 12-hour format
    now = datetime.now()
    hour = int(now.strftime("%I"))   # 12-hour format hour
    minute = int(now.strftime("%M")) # minute
    ampm = now.strftime("%p")        # "AM" or "PM"

    # Show HH:MM, with colon blinking
    tm.numbers(hour, minute, colon)
    colon = not colon

    # Also print to terminal with AM/PM
    print(f"{hour:02d}:{minute:02d} {ampm}")

    time.sleep(1)
