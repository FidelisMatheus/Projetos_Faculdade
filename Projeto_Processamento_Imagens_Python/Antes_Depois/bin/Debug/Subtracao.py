import cv2
import os
import numpy as np

dim = (640,480)
image1 = cv2.imread("Antes.jpg")
image1 = cv2.resize(image1, dim)
image1 = cv2.medianBlur(image1, 3)

image2 = cv2.imread("Depois.jpg") 
image2 = cv2.resize(image2, dim)
image2 = cv2.medianBlur(image2, 3)

if os.path.isfile("Resultado.jpg"):
    os.remove("Resultado.jpg")
    sub = cv2.subtract(image1, image2)
    cv2.imwrite("Resultado.jpg", sub)
else:
    sub = cv2.subtract(image1, image2)
    cv2.imwrite("Resultado.jpg", sub)

image3 = cv2.imread('Resultado.jpg')
kernel = np.array([[0, -1, 0],
                   [-1, 5,-1],
                   [0, -1, 0]])
image_sharp = cv2.filter2D(image3, ddepth=-1, kernel=kernel)
cv2.imwrite("Resultado.jpg", image_sharp)

cv2.destroyAllWindows() 
