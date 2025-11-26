import pyautogui as pa
import time

while True:
    x, y = pa.position() # 좌표 추출
    r,g,b = pa.pixel(x,y) # RGB 추출
    print(f"커서 위치: ({x}, {y}) / 해당위치 색상: ({r},{g},{b})      ", end='\r')
    time.sleep(0.1)