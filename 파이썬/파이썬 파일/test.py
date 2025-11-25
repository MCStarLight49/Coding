n = int(input("숫자입력:"))
answer = [[0]*n for i in range(n)]
count = 1

right = 0
right_c = 0
down = 0
down_c = 0
left = n-1
left_c = 0
up = n-2
up_c = 0
up_ = 0

while (count <= n**2):
    # right
    for i in range(n-right_c):
        answer[right][right+i] = count
        count += 1
    right_c += 2
    right += 1
    
    # down
    for i in range(n-1-down_c):
        answer[i+1+down][n-1-down] = count
        count += 1
    down_c += 2
    down += 1
    
    # left
    for i in range(n-1-left_c):
        answer[left][left-1-i] = count
        count += 1
    left_c += 2
    left -= 1
    
    # up
    for i in range(n-2-up_c):
        answer[up-i][up_] = count
        count += 1
    up_c += 2
    up_ += 1
    up -= 1

print("\n"*10)
for i in range(n):
    print(answer[i])