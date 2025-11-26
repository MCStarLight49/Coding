def sn(n) : # 공약수

    for i in range(1, n+1) :
        if ((n % i) == 0) :
            nlist.append(i)
         
nlist = []

n1 = int(input("첫번째 숫자를 입력해주세요 -> "))
n2 = int(input("두번째 숫자를 입력해주세요 -> "))

sn(n1)
sn(n2)
nlist.sort()

i = len(nlist)-1
while(True) : # 최대공약수
    if (nlist[i] == nlist[i-1]) :
        maxnum = nlist[i]
        break
    else :
        i -= 1

minnum = int((n1 / maxnum)*(n2 / maxnum)*maxnum) # 최소공배수

print()
print("입력한 숫자 :", n1, ",", n2)
print("최대공약수 :", maxnum)
print("최소공배수 :", minnum)
