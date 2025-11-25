import random

answer = random.randint(1, 100)
guess = 0
t = 0

print("1부터 100까지의 숫자를 맞추시오")

while guess != answer :
    guess = int(input("숫자 입력 : "))
    if guess < answer :
        print(guess, "보다 높음")
    elif guess > answer :
        print(guess, "보다 낮음")
    t += 1
print(t, "번만에 성공")
