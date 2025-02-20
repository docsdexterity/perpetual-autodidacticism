#include <stdio.h>

int main(){

	/*
		Escape Sequence:
		- A character combination consisting of a backslash '\'
		  |--> followed by a letter or combination of digits.
		- They specify actions within a line or string of text.
		- Example:
		  |--> \n = newline
		  |--> \t = tab
	*/

	printf("I\nlike\nramen!\n");
	/*
		Output:
		I
		like
		ramen!
	*/

	printf("\n"); // For spacing

	printf("1\t2\t3\n");
	printf("4\t5\t6\n");
	printf("7\t8\t9\n");
	/*
		Escape sequence, '\t', adds an even spacing between characters.
		Output: (is a grid of numbers)
		1	2	3
		4	5	6
		7	8	9
	*/

	/*
		For quotation, escape sequences are used as well.
		|--> single quotes (' ') or double quotes (" ")
		|--> if typed incorrectly, the compiler wouldn't know where does the string starts & ends at
		|--> so before quote mark or symbols, add a backslash, e.g '\"'

		For backslash, it's a backslash followed by another backslash i.e. '\\'
	*/

	printf("\n"); // For spacing

	printf("\"But in the end one needs more courage to live than to kill himself.\"\n\t - Albert Camus\n");

	/*
		Output:
		"But in the end one needs more courage to live than to kill himself."
				- Albert Camus
	*/

	printf("\n"); // For spacing

	printf("This is a backslash i.e. \'\\\'.");

	// Output: This is a backslash i.e. '\'.

	return 0;
}