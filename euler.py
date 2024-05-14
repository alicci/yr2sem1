import numpy as np
import matplotlib.pyplot as plt
 
 
def Euler(rhs,a,b,y0,dt):
    t = np.arange(a,b+dt,dt)
    n = len(t)
    y = np.zeros(n)
    i = np.arange(1,n,1)
    y[0] = y0
    for k in i:
        m = rhs(t[k-1])
        y[k] = m*dt+y[k-1]
    return t,y
 
# ex.6(b)
def rhs(t):
    m = (t ** 2) - np.sin(t)
    return m
 
# ex.6(c)
def solution(x):
    y = ((x**3)/3) + np.cos(x) - 1
    return y
 
# [a,b] - interval, dt - step-size

t,y = Euler(rhs,0,2*np.pi,0,.1 )
 
plt.plot(t,y, 'b')
plt.autoscale(enable=True, axis='x', tight=True)
plt.xlabel('t')
plt.ylabel('y')
plt.plot(t,solution(t),'b--')
plt.legend(['Approximation','True Solution'])
plt.grid()
plt.show()
 