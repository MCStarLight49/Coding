def abs_f(n) :

    if (n < 0) :
        n *= -1

    return n
    

'''print(abs_f(-4+1))
print(abs_f(2))
print(abs_f(-3295))'''

num = int(input("숫자를 입력해주세요 -> "))
print("숫자", num, "의 절댓값은", abs_f(num), "입니다.")

print()
print("구구단")

for i in range(1, 10) :
    print(num, "x", i, "=", num*i)
