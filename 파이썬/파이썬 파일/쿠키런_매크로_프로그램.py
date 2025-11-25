# 창크기 960px x 540px / 에피2만 가능

import pyautogui as pa
import time
import random as r
import imagehash
import win32gui

# 경고 메세지 무시
import warnings
warnings.filterwarnings("ignore", category=UserWarning) 

# 타이머 객체
class c_timer:
    def __init__(self, set):
        self.hour, self.min = 0, 0
        if (set//3600 > 0):
            self.hour = set//3600
            set %= 3600
        if (set//60 > 0):
            self.min = set//60
            set %= 60
        self.sec = set

# 반복횟수, 클릭딜레이_변수
count, nox_cy = -1, 0
img_end = "C:\\cookierun_auto\\cookierun_end.png" # 종료 이미지
img_card = "C:\\cookierun_auto\\cookierun_card.png" # 카드 이미지
img_box = "C:\\cookierun_auto\\cookierun_box.png" # 미박 이미지
img_second = "C:\\cookierun_auto\\cookierun_second.png" # 이달 이미지
img_boost = "C:\\cookierun_auto\\cookierun_boost.png" # 빠스 이미지

# ------------------------------------------------------------

# nox창 찾는 함수 --
def find_nox():
    def callback(hwnd, result): # 창검사
        if win32gui.IsWindowVisible(hwnd):
            title = win32gui.GetWindowText(hwnd)
            if "nox" in title.lower(): result.append(hwnd)
    windows = []
    win32gui.EnumWindows(callback, windows) # 열려 있는 모든창 검사
    return windows[0] if windows else None

# 상대좌표 -> 절대좌표 함수 --
def rel_to_abso(x=0, y=0):
    up_x, up_y, temp, down_y = win32gui.GetWindowRect(win_nox)
    title_y =  (down_y - up_y) - 540
    abso_x = x + up_x
    abso_y = title_y + y + up_y
    if (x != 0 and y != 0): return abso_x, abso_y
    elif (x != 0): return abso_x
    elif (y != 0): return abso_y
    else: return up_x, (title_y + up_y)

# 종료,미박 함수 --
def c_box_end(x,y,img):
    global nox_cy
    try: 
        pa.locateOnScreen(img, confidence=0.8) # 사진감지
        nox_cy = 1000
        pa.click(x,y)
    except Exception: pass

# 카드게임 함수 --
def c_card():
    global nox_cy
    try:
        pa.locateOnScreen(img_card, confidence=0.8) # 사진감지
        
        # 카드 위치
        card_pos = [
            # 위
            (rel_to_abso(x=290), rel_to_abso(y=210), 80, 90),
            (rel_to_abso(x=437), rel_to_abso(y=210), 80, 90),
            (rel_to_abso(x=584), rel_to_abso(y=210), 80, 90),
            # 아래
            (rel_to_abso(x=290), rel_to_abso(y=402), 80, 90),
            (rel_to_abso(x=437), rel_to_abso(y=402), 80, 90),
            (rel_to_abso(x=584), rel_to_abso(y=402), 80, 90)
        ]
        # 카드 클릭위치
        card_click = (
            # 위
            rel_to_abso(330, 250),
            rel_to_abso(480, 250),
            rel_to_abso(630, 250),
            # 아래
            rel_to_abso(330, 450),
            rel_to_abso(480, 450),
            rel_to_abso(630, 450)
        )

        nox_cy = 995
        screen = pa.screenshot() # 전체화면 스샷
        card_img = []

        # 카드 이미지 추출
        for pos in card_pos:
            x, y, w, h = pos
            cropped = screen.crop((x, y, x + w, y + h)) # 사각형으로 저장
            card_img.append(cropped)

        # 이미지 해시 추출 및 비교
        hashes = []
        for img in card_img: hashes.append(imagehash.whash(img, hash_size=2, mode="coif1")) # 해시 추출
        hash_str = [str(i) for i in hashes] # 문자열로 변환
        hash_team = [True] # T, F 로 사진 구분
        for i in range(1,len(hash_str)):
            cnt = 0
            for j in range(len(hash_str[0])):
                if (hash_str[0][j] != hash_str[i][j]): cnt += 1
            if (cnt >= 3): hash_team.append(False)
            else: hash_team.append(True)
            
        # 클릭 위치 추출
        re_pos = []
        for i in range(6):
            if ((hash_team.count(True) == 2 and hash_team[i]) or
            (hash_team.count(False) == 2 and not(hash_team[i]))): re_pos.append(card_click[i])
            
        # 카드 클릭
        if (len(re_pos) == 2):
            pa.click(re_pos[0][0], re_pos[0][1])
            time.sleep(0.5)
            pa.click(re_pos[1][0], re_pos[1][1])
        else: # 감지 실패시
            n = r.randint(0,5)
            pa.click(card_click[n][0], card_click[n][1])

    except Exception: pass

# ------------------------------------------------------------

# 메인 --
print("\n"*20)
tri = True
if ((win_nox := find_nox()) == None): # 창 유무검사
    print("nox창을 찾지 못했습니다.\n")
    tri = False
    import os
    os.system("pause")
else:
    use_second = bool(input("이어달리기 (값 입력시 사용) : "))
    use_boost = bool(input("빠른스타트 (값 입력시 사용) : "))
    print("\n"*40)
    print(f"이어달리기 : {"O" if use_second else "X"}\n빠른스타트 : {"O" if use_boost else "X"}\n")

start_t = int(time.time()) # 시작시간

while tri:
    # 경과시간
    current_t = c_timer(int(time.time()) - start_t)
    
    # 출력
    print(f" [ 시간 ] {current_t.hour:02}:{current_t.min:02}:{current_t.sec:02}  /  [ 완료횟수 ] {(count)}          ",end="\r")
    
    # 플레이
    if (nox_cy == 0 or nox_cy == 1):
        temp_x, temp_y = rel_to_abso(780, 480)
        pa.click(temp_x, temp_y) # 시작
        if (nox_cy == 0): count += 1
    else:
        if (use_boost): # 빠스
            try: 
                pa.locateOnScreen(img_boost ,confidence=0.8)
                temp_x, temp_y = rel_to_abso(480, 270)
                pa.click(temp_x, temp_y)
            except Exception: pass

        if (use_second): # 이달
            try: 
                pa.locateOnScreen(img_second ,confidence=0.8)
                temp_x, temp_y = rel_to_abso(480, 270)
                pa.click(temp_x, temp_y)
            except Exception: pass
        
        if (nox_cy < 1000): # 종료
            temp_x, temp_y = rel_to_abso(330, 480)
            c_box_end(temp_x, temp_y, img_end)

        if (nox_cy < 1005): # 미박
            temp_x, temp_y = rel_to_abso(555, 480)
            c_box_end(temp_x, temp_y, img_box)
        else: nox_cy = -1 # 딜레이 초기화

        c_card() # 카드게임

    time.sleep(0.5)
    nox_cy += 1
    # if(count >= 1): break