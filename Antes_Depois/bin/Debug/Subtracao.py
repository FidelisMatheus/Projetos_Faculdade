import cv2
from PIL import Image

dim = (640,480)
image1 = cv2.imread('Antes.png')
image1 = cv2.resize(image1, dim)
image1 = cv2.medianBlur(image1, 3)

image2 = cv2.imread('Depois.png') 
image2 = cv2.resize(image2, dim)
image2 = cv2.medianBlur(image2, 3)

sub = cv2.subtract(image1, image2)
cv2.imwrite("Resultado.png", sub)

imgGray = cv2.imread('Resultado.png',0)
cv2.imwrite("Cinza.png", imgGray)

cv2.destroyAllWindows() 
