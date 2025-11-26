import random

options = ["왼쪽", "중앙", "오른쪽"]
c_c = random.choice([options])
u_c = input("어디를 수비하시겠어요?(왼쪽, 중앙, 오른쪽) : ")

if c_c == u_c :
    print("수비 성공")
else :
    print("수비 실패")