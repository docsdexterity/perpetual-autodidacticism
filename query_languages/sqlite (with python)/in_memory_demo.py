# app --> employees
# functions --> create, update and delete
# queries --> grab employee information from the database

import sqlite3

# importing the Employee class
from employee import Employee

# connection object that represents our database
# for in memory database, pass ':memory:' inside .connect()
# for simple database, simply pass the filename inside .connect()
# conn = sqlite3.connect('employee.db')

# for testing you can use :memory: inside .connect()
conn = sqlite3.connect(':memory:')
# so on every run, it creates the table and inserts the employees again

"""
	--> upon execution, employee.db is created
	--> and if the file exists, then it's simply connected
"""

# cursor which allows to execute SQL commands
c = conn.cursor()

# creating an employees table
# it'll hold data like firstname, lastname, and pay
# inside .execute(), wrap SQL commands inside three quotes on each side
# this is also referred to as docstrings (as in Python documentation)

# c.execute(
#  	"""CREATE TABLE employees (
#  		first text,
#  		last text,
#  		pay integer
#  	)"""
# )

# the above code is commented out because the table has been already created
# running that codeblock again will give back an operational error
# i.e. sqlite3.OperationalError: table employees already exists

"""
	there is an if not exists clause in SQL
	so if the table already exists, don't try to recreate
	CREATE TABLE IF NOT EXISTS employees
"""

# c.execute(
#  	"""CREATE TABLE IF NOT EXISTS employees (
#  		first text,
#  		last text,
#  		pay integer
#  	)"""
# )

# the following codeblock is uncommented because we are using in memory database for now
c.execute(
 	"""CREATE TABLE employees (
 		first text,
 		last text,
 		pay integer
 	)"""
)

# adding an employee to the database
# c.execute("INSERT INTO employees VALUES ('Jax', 'Teller', 100000)")
# c.execute("INSERT INTO employees VALUES ('Gemma', 'Teller', 200000)")
c.execute("INSERT INTO employees VALUES ('Jax', 'Morrow', 100000)")
c.execute("INSERT INTO employees VALUES ('Gemma', 'Morrow', 200000)")
conn.commit()

# querying data (standard way)
# c.execute("SELECT * FROM employees WHERE last='Teller'")

# retrieving data
# - .fetchone()
# - .fetchmany(x), x is the number of rows
# - .fetchall()
# print(c.fetchall())

# as this is python, we would have variables
# and we would want to import the values from there into the query

emp_1 = Employee('John', 'Doe', 50000)
emp_2 = Employee('Jane', 'Doe', 70000)
emp_3 = Employee('Alex', 'Doe', 90000)

# print(emp_1.first)
# print(emp_1.last)
# print(emp_1.pay)

# [AVOID THIS METHOD AT ALL COST!]
# adding emp_1 to the database using string formatting (NOT A SAFE PRACTICE}
# c.execute("INSERT INTO employees VALUES ('{}', '{}', {}".format(emp_1.first, emp_1.last, emp_1.pay))
# suppose you are taking values from an end user from a website or something like that
# then this is vulnerable to SQL injection attacks and basically all that means is 
# there are values that the user can set these variables equal to that could break the entire database
# and the reason for that is because it's not properly escaped	

# [CORRECT METHOD 1]
# we do this by getting rid of .format() method and replacing braces i.e. '{}' with ?
# the question mark is called a DB API placeholder followed by another argument
# containing tuple of all values
c.execute("INSERT INTO employees VALUES (?, ?, ?)", (emp_1.first, emp_1.last, emp_1.pay))
conn.commit()

# [CORRECT METHOD 2]
# nothing much, just replace tuples with dictionary
c.execute("INSERT INTO employees VALUES (:first, :last, :pay)", {'first': emp_2.first, 'last': emp_2.last, 'pay': emp_2.pay})
conn.commit()

# querying data again with updated methods
# with tuples --> 
# c.execute("SELECT * FROM employees WHERE last=?", ('Teller',))
c.execute("SELECT * FROM employees WHERE last=?", ('Morrow',))

print(c.fetchall())
# remember to put a comma in ('Teller',) or you will get an error
# with dictionary -->
c.execute("SELECT * FROM employees WHERE last=:last", {'last': 'Doe'})
print(c.fetchall())

# committing transactions using connection
conn.commit()

# closing the connection to the database
conn.close() 
