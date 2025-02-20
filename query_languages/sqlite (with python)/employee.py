class Employee:

	"""A sample Employee class"""

	def __init__(self, first, last, pay):
		self.first = first
		self.last = last
		self.pay = pay

	"""
		__init__ is a constructor and the way it would behave is like when 
		emp = Employee("John", "Doe", 1000) is executed,
		an employee object is created.
	"""

	# @property is just a decorator (or descriptor) that gives away attributes rather than calling functions
	@property
	def email(self):
		return '{}.{}@email.com'.format(self.first, self.last)
		# {}.{}@email.com followed by .format() just replaces it with the first and last name

	# Decorators are functions that modify the behavior of another function or method

	@property
	def fullname(self):
		return '{} {}'.format(self.first, self.last)

	# __repr__ method returns a string representation of an object.
	def __repr__(self):
		return "Employee('{}', '{}', {})".format(self.first, self.last, self.pay)
	
