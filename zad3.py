import numpy as np
import matplotlib.pyplot as plt

def euler(rhs,a,b,y0,dt):
    t = np.arange(a,b+dt,dt)
    n = len(t)
    y = np.zeros(n)
    i = np.arange(1,n,1)
    y[0] = y0
    for k in i:
        m = rhs(t[k-1])
        y[k] = m*dt+y[k-1]
    return t,y


def rhs(t):
    m = (t ** 2) - np.sin(t)
    return m


t1,y1 = euler(rhs,0,2*np.pi,0,.1 )
t2,y2 = euler(rhs,0,2*np.pi,0,.2 )
t5,y5 = euler(rhs,0,2*np.pi,0,.5 )
 
plt.plot(t1,y1, 'b')
plt.plot(t2,y2,'r--')
plt.plot(t5,y5,'g--')

plt.xlabel('t')
plt.ylabel('y')
plt.grid()
plt.title("Zadanie 3")
plt.show()
 