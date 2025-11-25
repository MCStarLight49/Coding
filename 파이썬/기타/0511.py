import turtle
t = turtle.Turtle()
t.shape("turtle")
t.width(10)

'''for i in range(2) :
    t.color("#abffab")
    t.forward(100)
    t.left(90)
    t.color("#ffabff")
    t.forward(100)
    t.left(90)'''

'''for i in range(3) :
    t.forward(100)
    t.left(120)'''

'''for i in range(6) :
    t.forward(100)
    t.left(60)'''


n = turtle.textinput("무언가", "몇각형을 만드실건가요?")
n = int(n)
c = turtle.textinput("무언가", "어떤색을 사용하실건가요?")

t.color(c)
t.begin_fill()
for i in range(n) :
    t.forward(100)
    t.left(360/n)
t.end_fill()
