# Importing libraries
import matplotlib.pyplot as plt
import numpy as np
 
# Define a function
def f(x):
    return x ** 2
 
# Create x and y Ranges
x = np.linspace(-5, 5, 1000)
y = f(x)
 
# Plot  the Data
plt.plot(x, y)
plt.grid()
plt.show()