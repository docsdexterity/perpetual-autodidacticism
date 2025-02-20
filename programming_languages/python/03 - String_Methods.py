name = "Dazai"
song = "Kanjo Killa"

# Function: Standalone feature or functionality.
# --> A function is a piece of code that is called by name.
# --> It can be passed some data to operate on (i.e. the parameters) and can optionally return data (the return value).
# --> Each and every data that is passed to a function is explicitly passed.

# A method is a piece of code that is called by a name that is associated with an object.
# In most aspects, it is identical to a function except for two key differences:
# --> A method is implicitly passed the object on which it was called.
# --> A method is able to operate on data that is contained within the class.
# --> remember that an object is an instance of a class
# --> (the class is the definition, the object is an instance of that data)

# len() function is used to return the length of the string.
# --> inbuilt function in Python Programming Language
# --> takes string as a parameter
# --> returns an integer which is the length of the string
print(len(name))
print(len(song))

# .find() method
# .find() method finds the first occurence of the specified value
print(name.find("a"))
print(song.find("o"))

# .find() method returns -1 if the value is not found.
print(song.find("X"))

# .find() method is almost the same as the .index() method.
print(song.index("o"))

# however .index() method raises an exception if the value is not found.
# print(song.index("x"))

# .capitalize() method converts the first character of a string to an uppercase letter and all other alphabets to lowercase
test_str_1 = "ceasar"
print(test_str_1.capitalize())

test_str_2 = "HIMENO"
print(test_str_2.capitalize())

# .upper() method converts string into uppercase
text = "this is wrong!"
print(text.upper())

# .lower() method converts string into lowercase
text_2 = "THIS IS MY ROOM."
print(text_2.lower())

# .isdigit() method returns true/false depending upon whether the given string is a digit or not
print(text.isdigit()) # returns False
text_3 = "934398329"
print(text_3.isdigit()) # returns True

# .isalpha() method returns True if all the characters are alphabet letters (a-z). 
# Example of characters that are not alphabet letters: (space)!#%&? etc
text_4 = "jimcarrey"
print(text_4.isalpha())
# if you enter space between string characters then .isalpha() method returns False
print(text.isalpha())

# .count() method returns how many times an input substring occurs in a particular string
print(name.count("a"))

# .replace() method replaces an instance of a character or substring with an input substring
text_5 = "Ghost"
print(text_5.replace("G","t"))
print(text_5.replace("Gh","Fr"))

# to display a string variable multiple times we can multiply it with an integer value
# for e.g.
print(text_5*5)
