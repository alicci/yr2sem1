import numpy as np
import matplotlib.pyplot as plt

def f(x):
    if x <= 0:
        y= (np.pi * (x**2))/(2*x + 1)
        return y
    else:
        y = x**2
        return y


t = np.vectorize(f)
x = np.arange(-10,10,0.01) 
y = t(x)
plt.plot(x,y)
plt.grid()
plt.title("Zadanie 1")
plt.show()

 