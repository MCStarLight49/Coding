import turtle

t = turtle.Turtle()
t.shape("turtle")

def sq(length) :
    for i in range(4) :
        t.forward(length)
        t.right(90)

def ns(n, length) :
    for i in range(n) :
        t.forward(length)
        t.left(360/n)

for i in range(3, 10) :
    ns(i, i*10)
