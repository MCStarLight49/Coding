import turtle
import random

t1 = turtle.Turtle()
t2 = turtle.Turtle()
t3 = turtle.Turtle()

t1.shape("turtle")
t1.shapesize(3)
t1.pensize(3)
t1.color("#abffab")
#
t2.shape("turtle")
t2.shapesize(3)
t2.pensize(3)
t2.color("#ffabff")
#
t3.shape("turtle")
t3.shapesize(3)
t3.pensize(3)
t3.color("#00af00")

t1.up()
t1.goto(-300, 0)
#
t2.up()
t2.goto(-300, 100)
#
t3.up()
t3.goto(-300, -100)

t1.down()
t2.down()
t3.down()
for i in range(20) :
    d1 = random.randint(1, 100)
    t1.forward(d1)
    t1.stamp()
    d2 = random.randint(1, 100)
    t2.forward(d2)
    t2.stamp()
    d3 = random.randint(1, 100)
    t3.forward(d3)
    t3.stamp()
