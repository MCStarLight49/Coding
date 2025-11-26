import turtle

t = turtle.Turtle()
t.shape("turtle")
t.speed(0)

color = ["red", "orange", "yellow", "green", "skyblue", "blue", "purple"]

turtle.bgcolor("gold")

t.width(3)

length = 10

while length < 500 :
    t.forward(length)
    t.color(color[length%6])
    t.right(89)
    length += 5
