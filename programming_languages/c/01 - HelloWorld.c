/*
	#include
	
	- This is a pre-processor command that tells the compiler to include the contents of a file.
	- stdio.h stands for standard input output.
	- '.h' is an extension for header files.
	- This file contains some useful functions related to input and output.
*/

#include <stdio.h>

/*
	Entry point of our program is the main function.
	- Anything within the main() function is read procedurally
	  |--> starting from the top and working its way down.
	- Anything within the set of curly braces '{}' is withing the main function.
	- At the end of our main function, we are going to add statement 'return 0;'
	- A semicolon ';' is used to terminate a statement (analogous to a period in sentence).
	- 'return 0;' returns the exit status of our program
	  |--> return 0 (if our program runs successfully with no errors)
	  |--> return 1 (if there is an error)
	  |--> checks for errors to return the exit status
	  |--> is required at the end of the main() function
*/

int main(){

	// To display something we can use printf() function.
	// Since, it is a statement, it is mandatory to end it with a semicolon ';'.

	/*
		printf("I like ramen!"); 
		printf("It's really good.");

		The output of both of these printf statements is:
		|--> I like ramen!It's really good.
	*/
	
	/* To output the second line of text on the next line:
	   |--> add an escape sequence for a new line character
	   |--> within printf() statement, inside of double quotes, add backslash n i.e. '\n'
	   |--> '\n' is an escape sequence for a new character
	*/

	printf("I like ramen!\n"); 
	printf("It's really good.\n");

	/* Output:
	   I like ramen!
	   It's really good.
	   (blank line)

	   A blank line is also displayed in the output after the second line, 
	   |--> this is because of \n in the second printf() statement.
	*/

	return 0;
}

/*
	For compilation and execution:
	- open terminal in working directory
	- type 'gcc -o filename filename.c'
	- the above command compiles the C program
	- the '-o' flag indicates the output file, i.e. what your object-file or executable should be
	- P.S. filename could be anything, e.g. a, b or HelloWorld (in this case)
	- now in next prompt, run 'filename.exe' to see the output of your C program
	- compilation of filename.c results in a filename.exe file
*/