# Typecasting is an ability or a feature that allows to convert the data type of a value to another data type

x = 1     # int
y = 2.0   # float
z = "3"   # str

a = str(x)
b = int(y)
c = float(z)

print(a)
print(type(a))
print(b)
print(type(b))
print(c)
print(type(c))
print(c*7.9)

# print("User has decided to show: " + b)
# this generates TypeError: can only concatenate str (not "int") to str

# correct way is to typecast the selected variable
print("User has decided to show: " + str(b))
