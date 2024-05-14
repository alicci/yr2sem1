import numpy as np
import matplotlib.pyplot as plt

def bisect(f,a,b,tol):
    x = (a+b)/2
    itnum = 0;
    while np.abs(f(x))>tol:
        itnum = itnum+1
        print('a={:.5f} f(a)={:.5f}, b={:.5f} f(b)={:.5f}, \
        x={:.5f} f(x)={:.5f}'.format(a,f(a),b,f(b),x,f(x)))
        if f(a)*f(x) < 0:
            b = x
        elif f(b)*f(x)<0:
            a = x
        else:

            break
        x = (a+b)/2
    return x,itnum

def f(x):
    y = x*x*x - (100*np.cos(x))
    return y

tol = 0.001
a = -1
b = 4
itnum1 = 0
x,itnum1 = bisect(f,a,b,tol)
print(itnum1)
print('final x =',x)
print('final f(x) =',f(x))

x = np.linspace(a,b,100) 
y = f(x)
plt.plot(x,y)
plt.grid()
plt.show()

