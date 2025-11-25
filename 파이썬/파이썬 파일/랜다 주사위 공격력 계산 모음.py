# 7성 기준
dice = int(input('주사위[ 요새:1 / 영혼수집:2 ] : '))
if (dice == 2): soul_stack = int(input("영혼갯수 : "))
lvl = int(input("클래스 : "))
moon = bool(input("달 버프 (입력시 적용) : "))
bk = bool(input("균열 (입력시 적용) : "))
# cri = int(input("크리(%) : "))



cri = 0
__lvl = lvl-7
if (dice == 1): # 요새
    dmg = 220 + 30*__lvl # 공격력
    up_dmg = 1.7 + 0.2*__lvl # 공격력 증가량
    up_plus = 4 + 0.5*__lvl # 추가 배수
    damage = int(dmg*up_dmg*up_plus*7*28) # re

elif (dice == 2): # 영혼수집
    up_dmg = 140 + 20*__lvl # 공격력 증가량
    damage = 30 + up_dmg*soul_stack



damage = int(damage * (2.524 if bk else 1) * (1.7 if moon else 1)) # 달, 균열 적용
print(f"\n클래스 : {lvl} / 공격력 : {damage} / 크리적용 : {int(damage*cri)}\n")