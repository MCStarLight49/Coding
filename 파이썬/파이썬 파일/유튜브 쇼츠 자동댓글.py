# 왼쪽 화면 절반 / 웨일
# 위치 [ 840 1240 ]
# 16  16  16 (26, 26, 26)
# 138 146 146
# 190 196 196
import pyautogui as pa
import time as t

x, y = 840, 1228
i = 1
while True:
    # 댓글창 클릭
    if (pa.pixel(480,1245) == (26, 26, 26)):
        pa.click(x, y)
        t.sleep(0.1)

    # 댓글 입력
    if (pa.pixel(x,y) == (138, 146, 146)): pa.typewrite("?"+str(i))

    # 댓글 완료
    if (pa.pixel(x,y) == (190, 196, 196)): 
        pa.click(x, y)
        i += 1
    
    # 마우스 움직이면 종료
    if (pa.position() != (x,y)): break