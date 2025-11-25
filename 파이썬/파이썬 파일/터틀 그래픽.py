import turtle as t
import tkinter as tk
from tkinter import simpledialog ,messagebox

# - 내꺼 -
# a = 2
# tri = True
# while (tri):
#     for i in range(1,10):
#         for j in range(a,a+3):
#             if (j >= 10):
#                 tri = False
#                 break
#             print(f"{j} X {i} = {i*j}", end='\t')
#         print()
#     a += 3
#     print()

# - nova님 -
# y=0
# for x in range(2,9,3):
#   if x==8:
#     y-=1
#   for col in range(1,10):
#     for row in range(x,x+y+3):
#       print(f"{row} x {col} = {row*col}", end="\t")
#     print()
#   print()

# ======================================================================

# - 모래시계 -
# num = int(input("숫자 입력 : "))
# print("*"*(num+1))
# j = 1
# for i in range(num-1,1, -2):
#     print(("*"*j) + (" "*i) +("*"*j))
#     j += 1
# j = 0
# for i in range(1,num, 2):
#     print(("*"*(num//2-j)) + (" "*i) +("*"*(num//2-j)))
#     j += 1
# print("*"*(num+1))

# ======================================================================

# 무한 중첩별
# size = 300
# t.speed(-1)
# while(True):
#     t.forward(size)
#     t.right(144)
#     t.forward(size)
#     t.left(72)
#     size -= 2

# ======================================================================

# --- 시어핀스키 삼각형 --- 실패

# 삼각형
# def triangle():
#     t.setheading(-60)
#     for i in range(3):
#         t.forward(size)
#         t.right(120)

# 삼각형 기본단위
# def t_normal():
#     triangle()
#     t.setheading(60)
#     for i in range(2):
#         t.forward(size)
#         triangle()

# def up(n):
#     t.backward(size*(2**n-1))
#     t.setheading(60)
#     t.forward(size)
# def down(n):
#     t.forward(size)
#     t.right(60)
#     t.forward(size*(2**n-1))

# # 메인
# def main(n1, n2, n3, m):
#     while (True):
#         if (m):
#             if (updown[n3]): # up
#                 print('up')
#                 up(n1)
#                 n1 -= n2
#                 updown[n3] = False
#                 if (n3+1 == len(updown) or n3 > 0):
#                     if (len(updown) != 1):
#                         n3 -= 1
#                         n2 -= 1
#             elif (not(updown[n3])): # down
#                 print('down')
#                 down(n1)
#                 n1 -= n2
#                 if (n3 > 0):
#                     n2 -= 1
#                     if (n3+1 == len(updown)):
#                         updown.pop(n3)
#                         print("pop")
#                     n3 -= 1
#                 else:
#                     updown[n3] = True
#                     n2 += 1
#                     n3 += 1
#         t_normal()
#         up(n1)
#         t_normal()
#         down(n1)
#         t_normal()
#         if (len(updown) > 0):
#             n1 += n2
#             m = True
#             continue
#         break


# # 설정
# size = 25 # 삼각형 크기
# t.speed(200) # 속도
# n = 4
# t.penup()
# t.goto(-300,-200) # 시작위치 (왼쪽아래)
# t.pendown()
#n = int(simpledialog.askstring("입력", "숫자 (0 이상)"))

# # - 시스템 -
# updown = [] # True : up / False : down
# if(n==0):
#     triangle()
#     messagebox.showwarning("완성", "완성")
# elif(n==1):
#     t_normal()
#     messagebox.showwarning("완성", "완성")
# elif(n>1):
#     for i in range(n-2):
#         updown.append(True)
#     main(1, 1, 0, False)
#     messagebox.showwarning("완성", "완성")
# else:
#     messagebox.showwarning("오류", "잘못된 값입니다.")

# --------------------

# 삼각형
# def triangle():
#     t.pendown()
#     for i in range(3):
#         t.forward(size)
#         t.left(120)
#     t.penup()

# # 메인
# def main(arr):
#     i_ = 0
#     for i in arr:
#         for j in arr[i_]:
#             if (j == True): triangle()
#             t.forward(size)
#         t.backward(size*len(i))
#         t.left(60)
#         t.forward(size)
#         t.right(60)
#         i_ += 1
        

# # 설정
# size = 25 # 삼각형 크기
# t.speed(100) # 속도
# n = 5
# t.penup()
# t.goto(-300,-200) # 시작위치 (왼쪽아래)
# t.pendown()

# # 시스템 start
# arr_t = [[True for j in range(0+i, 2**n)]for i in range(2**n)]
# arr_no = [1,2,2,4]
# print(arr_no)

# for i in range(1, 2**n-2):
#     for j in range(1,2**n-i-1):
#         if (i%4 == 1):
#             if (j%2 == 1):
#                 arr_t[i][j] = False
#         elif (i%4 == 2):
#             if (j%4 == 2 or j%4 == 3):
#                 arr_t[i][j] = False
#         elif (i%4 == 3):
#             if (j%4 != 0):
#                 arr_t[i][j] = False
#         elif (i%4 == 0):
#             if (j%4 == 4 or j%4 == 5 or j%4 == 6 or j%4 == 7):
#                 arr_t[i][j] = False
# #print(arr_t)
# main(arr_t)
# messagebox.showwarning("완성", "완성")

# --------------------

# GPT 찬스
# def GPTmain(order, size):
#     if order == 0:
#         for _ in range(3):
#             t.forward(size)
#             t.left(120)
#     else:
#         GPTmain(order-1, size/2)
#         t.forward(size/2)
#         GPTmain(order-1, size/2)    
#         t.backward(size/2)
#         t.left(60)
#         t.forward(size/2)
#         t.right(60)
#         GPTmain(order-1, size/2)
#         t.left(60)
#         t.backward(size/2)
#         t.right(60)

# # 터틀 설정
# t.speed(0)  # 가장 빠른 속도
# t.penup()
# t.goto(-600, -520)  # 시작 위치로 이동
# t.pendown()

# # 시어핀스키 삼각형 그리기 (차수 4, 크기 400)
# t.tracer(0, 0)
# GPTmain(10, 1200)
# t.update()
# t.done()

# ======================================================================

# --- 프랙탈 정사각형 ---

# def fr_square(n, size):
#     if n ==0:
#         t.begin_fill()
#         for i in range(4):
#             t.forward(size)
#             t.left(90)
#         t.end_fill()
#     else:
#         fr_square(n-1,size/3) # 왼쪽아래
#         t.forward(size/3)
#         t.left(90)
#         t.forward(size/3)
#         t.right(90)
#         fr_square(n-1,size/3) # 가운데
#         t.left(90)
#         t.forward(size/3)
#         t.right(90)
#         t.backward(size/3)
#         fr_square(n-1,size/3) # 왼쪽위
#         t.forward(size/3*2)
#         fr_square(n-1,size/3) # 오른쪽위
#         t.right(90)
#         t.forward(size/3*2)
#         t.left(90)
#         fr_square(n-1,size/3) # 오른쪽아래
#         t.backward(size/3*2)

# # 시작
# s = True # 즉시완성
# n = 4 # n
# size = 1000 # 크기

# t.penup()
# if (s): t.tracer(3000, 0)
# else: t.speed(0) # 속도
# t.goto(-500, -500) # 시작위치
# fr_square(n, size) # 함수시작
# t.update()
# t.done()

# ======================================================================

# --- 시어핀스키 카펫 ---

# def fr_square2(n, size):
#     if n ==0:
#         t.begin_fill()
#         for i in range(4):
#             t.forward(size)
#             t.left(90)
#         t.end_fill()
#     else:
#         fr_square2(n-1,size/3) # 왼쪽아래
#         t.forward(size/3)
#         fr_square2(n-1,size/3) # 가운데아래
#         t.forward(size/3)
#         fr_square2(n-1,size/3) # 오른쪽아래
#         t.backward(size/3*2)
#         t.left(90)
#         t.forward(size/3)
#         t.right(90)
#         fr_square2(n-1,size/3) # 오른쪽가운데
#         t.forward(size/3*2)
#         fr_square2(n-1,size/3) # 왼쪽가운데
#         t.left(90)
#         t.forward(size/3)
#         t.right(90)
#         fr_square2(n-1,size/3) # 왼쪽위
#         t.backward(size/3)
#         fr_square2(n-1,size/3) # 가운데위
#         t.backward(size/3)
#         fr_square2(n-1,size/3) # 오른쪽위
#         t.right(90)
#         t.forward(size/3*2)
#         t.left(90)
    

# # 시작
# s = True # 즉시완성
# n = 5 # n
# size = 1000 # 크기

# t.penup()
# if (s): t.tracer(0, 0)
# else: t.speed(10) # 속도
# t.goto(-500, -500) # 시작위치
# fr_square2(n, size) # 함수시작
# t.update()
# t.done()

# ======================================================================

# --- 삼각형으로 별 만들기 ---

# size = 300
# t.speed(-1)
# while(True):
#     t.forward(size)
#     t.right(170)
#     t.forward(size)
#     t.left(1)