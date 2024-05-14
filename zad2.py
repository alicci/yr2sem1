import numpy as np
import matplotlib.pyplot as plt


def bisect(f,a,b,tol):
    x = (a+b)/2
    while np.abs(f(x)>tol):
        if f(a)*f(x) < 0:
            b = x
        elif f(b)*f(x)<0:
            a = x
        else:
            break
        x = (a+b)/2

    return x


def f(x):
    y = (np.e**x) - 4
    return y


tol = 0.0001
a = 0
b = 2
x = bisect(f,a,b,tol)

print('f(x) =',f(x))

x = np.linspace(a,b,100) 
y = f(x)
plt.plot(x,y)
plt.grid()
plt.plot(0,0 ,'r', fillstyle= 'none', markersize=10)
plt.title("Zadanie 2")
plt.show()
