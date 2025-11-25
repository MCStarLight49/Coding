import turtle
t = turtle.Turtle()
t.shape("turtle")

'''t.color("red")
t.stamp()

move = 30
for i in range(12) :
    t.up()
    t.forward(50)
    t.down()
    t.forward(25)
    t.up()
    t.forward(15)
    t.stamp()
    t.home()
    t.right(move)
    move += 30'''

t.left(90)

for i in range(6) :
    t.forward(100)
    t.forward(-30)
    t.left(60)
    t.forward(30)
    t.forward(-30)

    t.right(120)
    t.forward(30)
    t.forward(-30)

    t.left(60)
    t.forward(-70)
    t.left(60)
