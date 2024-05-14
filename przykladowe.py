import numpy as np
import matplotlib.pyplot as plt

# #Python lists
# x = [1,2,3,4]
# print("x= ", x)
# y = [1, "a", 3.14, "c", "will"]
# print("y= ", y)
 
# #Graphic functions
# import matplotlib.pyplot as plt
# x = [0, 1, 2, 3, 4, 5]
# y = [0, 1, 4, 9, 16, 25]
# plt.plot(x, y)
# plt.show()
 

# #Graphic functions
# import matplotlib.pyplot as plt
# x=[0, 1, 2, 3, 4, 5]
# y = [0, 1, 4, 9, 16, 25]
# z = [0, 2, 4, 6, 8, 10]
# plt.plot(x, y, "b*-", label = "f(x) = x^2")
# plt.xlabel("x-axis")
# plt.ylabel("y-axis")
# plt.title("Big Title")
# plt.grid()
# plt.plot(x, z, "b--", label = "f'(x) = 2x", c = "0.45")
# plt.legend()
# plt.show()
 

# import numpy as np
# x = np.arange(0,5,1)
# print("x= ", x)
 

# import numpy as np
# import matplotlib.pyplot as plt
# np.set_printoptions(precision=3,suppress=1, floatmode="fixed")
# def f(x):
#    y = x**2
#    return y
# x = np.arange(0,5.1,0.1)
# print("x= ", x)
# y = f(x)
# print("y= ", y)
# z = np.sin(x)
# plt.plot(x,y)
# plt.xlabel("x-axis")
# plt.ylabel("y-axis")
# plt.title("f(x) = x^2")
# plt.grid()
# plt.figure()
# plt.plot(x,z)
# plt.grid()
# plt.show()
 

# x = float(input("Enter an x value: "))
# if x<=0:
#    y = x**2   #condition is true
# else:
#    y= x+1     #condition is false
#    print("f({}) = {}".format(x,y))