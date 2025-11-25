import turtle
t = turtle.Turtle()
t.shape("turtle")

t.up()
t.goto(100, 100)
t.write("거북이가 여기 오면 양수입니다")

t.goto(100, 0)
t.write("거북이가 여기 오면 0입니다")

t.goto(100, -100)
t.write("거북이가 여기 오면 음수입니다")

t.goto(0, 0)
t.down()

s = int(turtle.textinput("누군가", "숫자 입력"))

if s > 0 :
    t.goto(100, 100)
elif s == 0 :
    t.goto(100, 0)
elif s < 0 :
    t.goto(100, -100)
