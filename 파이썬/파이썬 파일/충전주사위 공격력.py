damage = 300

lvl = int(input("레벨 입력 : "))
moon = bool(input("달 버프 (입력시 적용) : "))
bk = bool(input("균열 (입력시 적용) : "))
cri = int(input("크리(%) : "))

cri /= 100
for i in range(1, lvl):
    damage += 10*i

if (not(moon) and not(bk)): print(f"레벨 : {lvl} / 공격력 : {damage} / 크리적용 : {damage*cri}")
elif (moon and not(bk)): print(f"레벨 : {lvl} / 공격력 : {damage*1.7} / 크리적용 : {damage*cri*1.7}")

elif (not(moon) and bk): print(f"레벨 : {lvl} / 공격력 : {damage*2.524} / 크리적용 : {damage*cri*2.524}")
else: print(f"레벨 : {lvl} / 공격력 : {damage*2.524*1.7} / 크리적용 : {damage*cri*2.524*1.7}")