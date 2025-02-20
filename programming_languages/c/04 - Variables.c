#include <stdio.h>

int main(){

	/*
		Variable
		- Allocated space in memory to store a value.
		- We refer to a variable's name to access the stored value.
		- That variable now behaves as if it was the value it contains.
		- But we need to declare what type of data we are storing
		  |--> declare a name for a variable then precede it with the type of data
	*/

	/*
		Creating a variable is done in two steps:
		|--> Declaration + Initialization

		- First, we need to declare a variable
		  |--> to allocate some space in the memory to store a value.
		- So, we need to precede our variable name with the
		  |--> with the data type of what we plan to store in this variable.
	*/

	/* 
		If we want to store a whole integer,
	    |--> then precede the variable name with 'int'
	*/
	int x;		 		// Declaration
	x = 123;			// Initialization

	int y = 3489; 		// Declaration + Initialization

	// Variable names should be descriptive of what it does. E.g.
	int age = 21;		// Integer

	// For a number containing a decimal portion, we can use 'float'. E.g.
	float cgpa = 7.89; 	// Floating point number

	// For storing single characters, we can use 'char'. E.g.
	char grade = 'B';	// Single character

	/*
		Since C is not an object-oriented language, it doesn't have a string data type.
		|--> This is because strings are technically objects.
		So, for storing a series of characters, for e.g. like someone's name
		|--> we need to create an array.
		|--> And to create an array, we will follow our variable name with a set of square brackets.
		|--> E.g. datatype variablename[]
	*/

	char name[] = "Bro";	// An array of characters

	// For printing variable value
	// - use printf() statement
	// - inside parenthesis, within double quotes, specify a format specifier
	// - outside the quotes, place a comma followed by variable name
	// - and don't forget to end the printf() statement with a semicolon i.e ';'

	/*
		Format specifiers 
		- In C, format specifiers are used to take inputs and print the output of a type.
		- The symbol we use in every format specifier is %. 
		- Format specifiers tell the compiler about the type of data
		  |--> that must be given or input 
		  |--> and the type of data that must be printed on the screen.
	*/

	// Printing integer values
	printf("%d\n",x);		// Output: 123
	printf("%d\n",y);		// Output: 3489
	printf("%d\n",age);		// Output: 21

	// Printing float values
	// - By default, float values are printed upto 6 decimal places.
	// - However, you can select how many decimal places should be shown in the output.
	// - This can be done by adding a period followed by the number of decimal places before the f in %f.
	
	printf("%f\n",cgpa);	// Output: 7.890000
	printf("%.2f\n",cgpa);	// Output: 7.89

	// Prining single character
	printf("%c\n",grade);	// Output: B

	// Printng an array of characters (a string)
	printf("%s\n",name);	// Output: Bro

	/* For concatenating the variable value within a string,
	   |--> simply, place the format specifier wherever it looks suitable.
	   |--> For e.g. in a sentence, say "You are age years old."
	   |--> In this sentence, age will be replaced by %d.
	*/
	printf("Hey! How are you, %s?\n",name);	// Output: Hey! How are you, Bro?
	printf("You are %d years old.\n",age);	// Output: You are 21 years old.
	printf("Your average grade is %c and cgpa is %.2f.",grade,cgpa);
	// Output: Your average grade is B and cgpa is 7.89.

	return 0;
}