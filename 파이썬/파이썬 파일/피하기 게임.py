import turtle
import random
import time as t

# 변수 선언 --------------------------------
# 화면크기
screen_width = 600
screen_height = 600
# 속도
player_speed = 5
ball_speed = 5
# 공 생성주기(ms)
ball_t = 1000
# 키입력 상태
left_pressed = False
right_pressed = False
up_pressed = False
down_pressed = False

# 함수 선언 --------------------------------
# 입력중
def key_press(k_str):
    global left_pressed, right_pressed, up_pressed, down_pressed
    if k_str == "Left": left_pressed = True
    elif k_str == "Right": right_pressed = True
    elif k_str == "Up": up_pressed = True
    elif k_str == "Down": down_pressed = True

# 입력해제        
def key_release(k_str):
    global left_pressed, right_pressed, up_pressed, down_pressed
    if k_str == "Left": left_pressed = False
    elif k_str == "Right": right_pressed = False
    elif k_str == "Up": up_pressed = False
    elif k_str == "Down": down_pressed = False

# 공생성
def add_ball():
    global ball_i
    ball_list.append(Ball())
    ball_list[ball_i].reset_pos()
    ball_i += 1
    screen.ontimer(add_ball, ball_t)

# 충돌체크
def check_collision():
    for i in ball_list:
        if player.distance(i) < 20:
            return True
    return False

# 클래스 --------------------------------
""" 공 클래스
    turtle.Turtle()를 상속받고 있음
    super() : 부모 클래스
    __init__() : 초기화(자동 실행됌)
""" 
class Ball(turtle.Turtle):
    def __init__(self):
        # ball = turtle.Turtle() 이거랑 같은 의미
        super().__init__()
        self.move = None
        self.shape("circle")
        self.color("red")
        self.shapesize(1, 1)
        self.penup()
        self.reset_pos()
    # 위치 초기화
    def reset_pos(self):
        self.move = random.randint(1,4)
        # 1: 위, 2: 아래, 3: 오른쪽, 4: 왼쪽
        if (self.move == 1): self.goto(random.randint(-screen_width // 2 + 20, screen_width // 2 - 20), screen_height // 2)
        elif (self.move == 2): self.goto(random.randint(-screen_width // 2 + 20, screen_width // 2 - 20), -screen_height // 2)
        elif (self.move == 3): self.goto(screen_width // 2, random.randint(-screen_height // 2 + 20, screen_height // 2 - 20))
        else: self.goto(-screen_width // 2, random.randint(-screen_height // 2 + 20, screen_height // 2 - 20))
    # 이동
    def move_pos(self):
        if (self.move == 1):
            self.sety(self.ycor() - ball_speed)
            if (self.ycor() < -screen_height // 2): self.reset_pos()
        elif (self.move == 2): 
            self.sety(self.ycor() + ball_speed)
            if (self.ycor() > screen_height // 2): self.reset_pos()
        elif (self.move == 3): 
            self.setx(self.xcor() - ball_speed)
            if (self.xcor() < -screen_width // 2): self.reset_pos()
        else: 
            self.setx(self.xcor() + ball_speed)
            if (self.xcor() > screen_width // 2): self.reset_pos()

# 초기 설정 --------------------------------
# 화면 설정
screen = turtle.Screen()
screen.setup(screen_width, screen_height)
screen.bgcolor("black")
screen.title("피하기 게임")
screen.tracer(0)

# 키보드 입력 설정
screen.listen()
for i in ["Left", "Right", "Up", "Down"]:
    screen.onkeypress(lambda i=i:key_press(i), i)
    screen.onkeyrelease(lambda i=i:key_release(i), i)

# 플레이어 생성
player = turtle.Turtle()
player.shape("square")
player.color("cyan")
player.penup()
player.goto(0, 0)

# 메인 ---------------------------------
ball_list = []
ball_i = 0
add_ball()
start_t = t.time()
game_over = False
print("\n"*10)
while not game_over:
    # 플레이어 이동
    if left_pressed:
        x = player.xcor()
        if x > -screen_width // 2 + 20:
            player.setx(x - player_speed)
    if right_pressed:
        x = player.xcor()
        if x < screen_width // 2 - 20:
            player.setx(x + player_speed)
    if up_pressed:
        y = player.ycor()
        if y < screen_height // 2 - 20:
            player.sety(y + player_speed)
    if down_pressed:
        y = player.ycor()
        if y > -screen_height // 2 + 20:
            player.sety(y - player_speed)
    # 공 이동
    for i in ball_list:
        i.move_pos()
    # 충돌 체크
    game_over = check_collision()
    # 기타
    screen.tracer(1000) # 화면
    t.sleep(0.0167)
    end_t = t.time()
    print(f"[ {(end_t - start_t):.3} ]         ",end="\r")

# 최고기록 저장
tmp_str = ""
f_loc = "C:\\Users\\USER\\Desktop\\여러가지_기록들.txt"
best_score = 0.0
with open(f_loc, "r", encoding="utf8") as f:
    tmp_str = f.readlines()
    for i in tmp_str:
        if "최고기록" in i:
            best_score = float(i.split(" : ")[1].replace("초\n", ""))
            break
if best_score < (end_t - start_t):
    with open(f_loc, "w", encoding="utf8") as f:
        for i in tmp_str:
            if "최고기록" in i:
                f.write(f"최고기록 : {(end_t - start_t):.3}초\n")
            else:
                f.write(i)

# 종료
screen.bye()
end_t = t.time()
print(f"{"\n"*30}[ 게임 오버 ! ]")
print(f"생존시간 : {(end_t - start_t):.3}초")
input()