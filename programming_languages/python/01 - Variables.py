# string is a series of characters
name = "Angelo"
print(name)

# string literal (combining strings)
print("hello " + name)

# checking datatype of the variable
print(type(name))

first_name = "Angelo"
last_name = "Lagusa"
# string concatenation is combining two or more strings to create a new string
full_name = first_name + " " + last_name
print("Hello " + full_name)
# strings cannot be used for any mathematical operation.

# int --> integer
# make sure the value of the int variable is not in double quotes.
# double quoting will make it a string.
age = 21
# increment age by 1
age = age + 1
# another way of incrementing age by 1
age += 1
print(age)
print(type(age))

# concatenating a string with an integer generates an error
# for e.g.
age = "21"
age +=1
print(age)
# TypeError: can only concatenate str (not "int") to str
# for instance, let's say we want to display a message alongwith full_name and age.
# then most likely, we will run into a type error as full_name is a string variable and age is an int variable.
# To avoid this, we will need to convert the int variable i.e. age into string variable
# And one way to do that is Typecasting.
# for e.g.
first_name = "Osamu"
last_name = "Dazai"
full_name = first_name + " " + last_name
age = 21
age += 1
print("Hello " + full_name + ". You are " + str(age) + " years old.")

# float --> floating point number
# (a decimal number)
# float data type is a numeric value that can store a number that includes a decimal portion
# comparitively, an int data type cannot store a decimal portion
# the decimal portion indicates that it is a floating point number
height = 250.5
print(height)
print(type(height))
print("Your height is " + str(height) + " cm")

# boolean can store only true or false values
# useful with if statements
# basically serves its purpose when we want to check if a statement is true or not
human = True
print(human)
print(type(human))
print("Are you a human: " + str(human))











