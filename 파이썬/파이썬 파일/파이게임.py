import pygame
import sys

# pygame 초기화
pygame.init()

# 화면 크기 설정
screen = pygame.display.set_mode((800, 600))
pygame.display.set_caption("Simple Game")

# 색상 정의 (RGB 값)
WHITE = (255, 255, 255)
BLUE = (0, 0, 255)

# 게임 루프
running = True
while running:
    # 이벤트 처리
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            running = False
        if event.type == pygame.KEYDOWN:
            if event.key == pygame.K_SPACE:  # 스페이스바를 눌렀을 때
                print("Spacebar pressed!")

    # 화면을 흰색으로 채움
    screen.fill(WHITE)

    # 파란색 사각형 그리기
    pygame.draw.rect(screen, BLUE, (100, 100, 60, 60))

    # 화면 업데이트
    pygame.display.flip()

# pygame 종료
pygame.quit()
sys.exit()
