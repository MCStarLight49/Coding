import torch
from diffusers import StableDiffusionPipeline

# 모델 불러오기 (Stable Diffusion) - CPU로 설정
pipe = StableDiffusionPipeline.from_pretrained("CompVis/stable-diffusion-v1-4")
pipe = pipe.to("cuda")  # GPU로 실행
#pipe.enable_sequential_cpu_offload()


# 텍스트 프롬프트 설정
prompt = "eruption"

# 이미지 생성
for i in range(5):
    with torch.no_grad():
        image = pipe(prompt, width=512, height=512).images[0]
    image.save(f"와21{i}.png")