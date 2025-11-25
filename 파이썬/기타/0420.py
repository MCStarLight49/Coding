import turtle
t = turtle.Turtle()
t.shape("turtle")
n = 100

t.width(3)
t.color("red")
t.circle(n)

t.up()
t.goto(n*2, 0)
t.down()

t.color("orange")
t.circle(n)

t.up()
t.goto(n*2, -(n*2))
t.down()

t.color("yellow")
t.circle(n)

t.up()
t.goto(0, -(n*2))
t.down()

t.color("green")
t.circle(n)

t.up()
t.goto(0, -(n*4))
t.down()

t.color("skyblue")
t.circle(n)

t.up()
t.goto(n*2, -(n*4))
t.down()

t.color("blue")
t.circle(n)

t.up()
t.goto(n*2, -(n*6))
t.down()

t.color("purple")
t.circle(n)
