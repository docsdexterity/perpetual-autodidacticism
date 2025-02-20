# input() function allows user input
name = input("What is your name? ")
print("Hello " + name)

# Accepted user input is always of string data type
print(type(name))

# A string data type is a series of characters which means we cannot perform any math upon it.
# for e.g.
# age = input("What is your age? ")
# age = age + 1
# This generates a TypeError: can only concatenate str (not "int") to str 

# To perform math upon it we will have to cast it as either int data type or float data type
age = int(input("What is your age? "))
age = age + 1
print("You are " + str(age) + " years old.")
# What happens here is that we take a string input and immediately cast it into int data type.
# So that we can treat it as a number instead of a character.
# However when we want to concatenate this age with a string, we will have to cast age variable to a string data type.

# It is important to remember that literals should be relevant to the specified data type.

height = int(input("What is your height? "))
# GENERATES ValueError if a float or any other type of literal is given as input
print(height) 
# for e.g. ValueError: invalid literal for int() with base 10: '156.9'  
print(type(height))

weight = float(input("What is your weight? "))
print(weight)
print(type(weight))
# To display this weight in kgs we will have to cast it into a string variable
print("Your weight is " + str(weight) + " kgs.") 

