'''a = int(input("몇단을 외우실건가요? : "))

for i in range(10) : #range(처음값, 끝값+1, 증가값)
    print(a, "*", i, "=", a*i)'''


for i in range(2, 10) :
    print(i, "단")
    for j in range(1, 10) :
        print(i, "*", j, "=", i*j)
    print()
