import random

while True :
    x = random.randint(1, 10)
    y = random.randint(1, 10)
    print(x, "+", y, "=", end=" ")
    answer = int(input())

    if answer == x+y :
        print("정답")
        break
    else :
        print("오답")
