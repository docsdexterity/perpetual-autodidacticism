#include <stdio.h>

/*
	A comment is some text that is ignored by the compiler.
	- It is rather used as an explanation, description or a note
	  |--> either for yourself or someone else that is reading your code.

	- For single line comments, type two forward slashes i.e. '//' followed by some text.
	- For multi-line comments:
	  |--> type a forward slash followed by an asterisk to start the comment
	  |--> and to end it, type an asterisk followd by a forward slash
	  |--> in between comes the textual content of comment
*/

// This is a single line comment.

/* 
	This
	is
	a
	multi-line
	comment.
*/

int main(){
	printf("I like ramen!\n");
	return 0;
}