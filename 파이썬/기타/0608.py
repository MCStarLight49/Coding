import turtle
import random

t = turtle.Turtle()
t.shape("turtle")
t.speed(10)
t.width(2)
turtle.bgcolor("black")

cl = ["gold", "orange", "yellow", "skyblue", "#abffab", "white"]

for i in range(30):
    t.up()
    x = random.randint(-400, 400)
    y = random.randint(-400, 400)
    t.goto(x, y)
    w = random.randint(10, 50)
    c = random.randint(0, 5)
    t.color(cl[c])
    t.down()
    if (w < 15) :
        for j in range(5):
            t.forward(w)
            t.right(144)
    else :
        t.begin_fill()
        for j in range(5):
            t.forward(w)
            t.right(144)
        t.end_fill()
        
