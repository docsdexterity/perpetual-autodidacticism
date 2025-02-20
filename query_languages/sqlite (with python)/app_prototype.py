import sqlite3
from employee import Employee

conn = sqlite3.connect(':memory:')
c = conn.cursor()

c.execute(
 	"""CREATE TABLE employees (
 		first text,
 		last text,
 		pay integer
 	)"""
)

"""
	CONTEXT MANAGERS
	----------------
	They are a way for us to manage a setup and a teardown
	of resources automatically. It's common to see these
	when using things like files also because people don't 
	want to remember to close files everytime they open one
	and with SQLite connection objects can be used as context
	managers that automatically commit or rollback transactions.
	So, transactions will be automatically committed unless
	there's an exception and then it will be automatically 
	rolled back.
"""

# some functions for protoyping a simple SQL application
def insert_emp(emp):
	"""	function for inserting employees """

	# using context manager
	with conn:
		c.execute("INSERT INTO employees VALUES (:first, :last, :pay)", {'first': emp.first, 'last': emp.last, 'pay': emp.pay})

def get_emps_by_name(lastname):
	"""	function for getting employees by their last name """
	c.execute("SELECT * FROM employees WHERE last=:last", {'last': lastname})
	return c.fetchall()

def update_pay(emp, pay):
	"""	function for updating pay of employee(s) """
	with conn:
		c.execute("""UPDATE employees SET pay = :pay
			WHERE first = :first AND last = :last""",
			{'first': emp.first, 'last': emp.last, 'pay': pay})

def remove_emp(emp):
	"""	function for removing employees """
	with conn:
		c.execute('DELETE from employees WHERE first = :first AND last = :last',
			{'first': emp.first, 'last': emp.last})

emp_1 = Employee('John', 'Doe', 50000)
emp_2 = Employee('Jane', 'Doe', 70000)
emp_3 = Employee('Alex', 'Doe', 90000)

insert_emp(emp_1)
insert_emp(emp_2)
insert_emp(emp_3)

emps = get_emps_by_name('Doe')
print(emps)

update_pay(emp_2, 10000000)
remove_emp(emp_1)

emps = get_emps_by_name('Doe')
print(emps)

conn.close() 

