from picamera2 import Picamera2
from time import sleep

picam2 = Picamera2()

# Configure for video recording
video_config = picam2.create_video_configuration()
picam2.configure(video_config)

# Start recording
picam2.start_recording("/home/ancel/m1/video.h264")

print("Recording video for 10 seconds...")
sleep(10)

# Stop recording
picam2.stop_recording()

print("Video saved as video.h264")