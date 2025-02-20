/*
/	Arithmetic expression
	|--> An arithmetic expression is a combination of operands and operators.
	|--> Operands are values, variables, etc.
	|--> Operators are signs like +, -, *, /, %.
	|--> Arithmetic expression can be evaluated to a value.
	|--> For e.g. y = x + 5;
*/ 

let students = 20;
// students = students + 1; Output: 21
// students = students - 1; Output: 19
// students = students * 2; Output: 40
// students = students / 2; Output: 10
// console.log(students)

// % is a modulus operator
let extraStudents = students % 3; // Output: 2
console.log(extraStudents);

// Modulus operator (%) can be used for finding whether a number is even or odd.

// Augmented Assignment Operators can be used to write shorter arithmetic expressions.
// For e.g.
students += 1;
students -= 1;
students *= 2;
students /= 2;

// However, using something like '%=' will result in a SyntaxError: Unexpected token '%='.

/*
	Operator Precedence
	1. Parenthesis ()
	2. Exponents
	3. Multiplication & Division
	4. Addition & Subtraction
*/

let result = 1 + 2 * (3 + 4);
console.log(result);