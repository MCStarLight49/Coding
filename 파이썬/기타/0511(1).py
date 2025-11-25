import turtle
t = turtle.Turtle()
t.shape("turtle")
t.width(5)

cl = ["red", "orange", "yellow", "green", "skyblue", "blue", "purple"]

t.up()
t.goto(-200, 0)
t.down()

for i in range(6) :
    t.color(cl[i])
    t.begin_fill()
    t.circle(50)
    t.color(cl[i+1])
    t.end_fill()

    t.up()
    t.forward(80)
    t.down()

t.color("white")

# end = turtle.textinput("멈춰", "멈춰")
