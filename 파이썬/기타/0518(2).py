import turtle
import random

t = turtle.Turtle()
t.shape("turtle")

clist = ["red", "orange", "green", "blue", "purple", "gold"]
turtle.bgcolor("#ffabff")
for i in range(20) :
    length = random.randint(1, 100)
    t.forward(length)
    #angle = random.randint(-100, 100)
    angle = random.choice([90, 180, 270])
    t.right(angle)
    width = random.randint(1, 10)
    t.width(width)
    co = random.randint(0, 5)
    t.color(clist[co])
