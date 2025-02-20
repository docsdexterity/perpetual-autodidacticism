# string slicing --> creating a substring by extracting elements from another string
# This can be done by using either the indexing operator i.e [] or by slice() function to create a slice object

# for indexing operator i.e [], there are three optional arguments
# i.e [start:stop:step]
# start	--> starting index
# stop  --> stopping index
# step  --> determines increment between each character in a sequence
# these can filled depending upon where and how we want to slice our string

name = "Darth Vader"
# creating a substring based off of the first name
# to create a substring, simply type in the variable name followed by [] which contains the starting and stopping index values
first_name = name[0:5]
print(first_name)
# shorthand way --> first_name = name[:5]
# here python assumes that the starting index is 0 by default
# same can go with stopping index, however the value will be same as that of last index

# creating a substring for the last name
last_name = name[6:] # here the value of stopping index is same as last index in name variable
print(last_name)
