# math is a built-in python module for all the mathematical tasks and operations
import math

# round() is a built in function that returns the rounded version of the argument value
# for e.g.
pi = 3.14
print(round(pi))			# returns 3

# .ceil() method returns an integer greater than or equal to the input value
num_1 = 0
print(math.ceil(num_1))		# returns 0
num_2 = 5.68
print(math.ceil(num_2))		# returns 6
num_3 = 56
print(math.ceil(num_3))		# returns 56
# integer values may not be changed, however floating point values get rounded up to the nearest integer

# .floor() method returns an integer lower than or equal to the input value
num_4 = 7.34 			
print(math.floor(num_4))	# returns 7
num_5 = 96
print(math.floor(num_5))	# returns 96
# integer values may not be changed, however floating point values get rounded up to the nearest integer

# abs() --> short for absolute value function
# abs() function returns absolute value of the input value
# absolute value tells how far away a number is from zero
x = -56.25
print(abs(x))				# returns 56.25
# returns a positive value for negative input value

# pow() --> power function
# pow() function will raise a base number to a power
print(pow(pi,2))			# returns 9.8596
print(pow(x,2))				# returns 3164.0625

# .sqrt() method returns square root of the input value
print(math.sqrt(45))		# returns 6.708203932499369

a , b , c = 3334 , 4556 , 5343
# max() function returns the highest value
# min() function returns the lowerst value
print(max(a,b,c))			# returns 5343
print(min(a,b,c))			# returns 3334