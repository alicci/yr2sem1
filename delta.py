import math
#funkcja zwracajaca wyniki rownania kwadratowego 
 
def delta(a,b,c):
    d = (b*b) - 4*a*c
    if d < 0:
        return 0
    if d == 0: 
        return (-b)/2*a
    if  d > 0:
        return (-b + math.sqrt(d))/(2*a) , (-b - math.sqrt(d))/(2*a)
 
a = -1
b = 2
c = 3
 
delt = delta(a,b,c)
 
print(delt)