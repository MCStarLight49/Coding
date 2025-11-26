def dec_to_bin(f_num):
    n1 = int(f_num)*2 # 정수
    n2 = f_num - int(f_num) # 소수
    s_n1, s_n2 = "", ""
    
    while((n1:=n1//2) > 0): s_n1 = str(n1%2) + s_n1 # 정수 변환
    
    while(len(s_n1+s_n2) <= 23): # 실수 변환
        s_n2 += str(int(n2 := n2*2))
        if (n2 >= 1): n2 -= 1
        
    return ("0" if (int(f_num) == 0) else s_n1) +"."+s_n2
    

print(dec_to_bin(1.1))
print(dec_to_bin(0.1))
print(dec_to_bin(1))
print(dec_to_bin(0.2))
print(dec_to_bin(111111))
print(dec_to_bin(111111.1))
print(dec_to_bin(0.1))
print(dec_to_bin(3532.2114))