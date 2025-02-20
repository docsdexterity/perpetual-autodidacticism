// A variable is a container for storing data.
// It is a representation of a value.

/* 
	For e.g. 
				if 10 = x * 2, 
				then x = 5,
				where x is a variable and it represents the value '5'
*/

// A variable behaves as if it was the value that it contains.
// In the above example, we use 'x' in that expression as it was the value '5'.

/*
	Two steps (for creating a variable):

		1. Declaration (var, let, const)
		   |--> var, let, const are keywords 
		2. Assignment ('=' is known as assignment operator)
*/

// Creating a variable with keyword 'let' with a unique descriptive name (age)
let age; 	// Declaration

/*
	console.log(age);
	
	Output:
	'undefined' in console because age variable hasn't been assigned a value yet.
*/

age = 20; 	// Assignment

/*
	A variable can be created by using the below syntax as well.
	let age = 21;

	However, when dealing with user input, it's better to follow the two steps approach.
	(for creating variables) 
*/

// Different variables have different data types
// As of now, age is a number data type

age = age + 1;	// Using variable in an arithmetic expression

// String data type is a series of characters
let firstName = "Angelo";

// Boolean data type --> has only two values i.e. either True or False
let isStudent = true;

firstName = firstName + "!";

console.log("Hey there,",firstName);
console.log("You are",age,"years old.");
console.log("Enrollment status:",isStudent);

/*
	Number data types can be used in an arithmetic expression
	For e.g. age = age + 1;

	but if age was defined as 
	|--> let age = "21";
	and then we include age variable in an arithmetic expression like
	|--> age = age + 1;
	the output will be 211
	|--> this is because 'age = age + 1;' will concatenate the 1 at the end of value of age variable.
	|--> and this happens because 'let age = "21";' creates a string type variable.
*/

// Displaying variables in a DOM

/*
	A quick word on DOM:
	|--> It defines the logical structure of documents and the way a document is accessed and manipulated.
*/

/*
	Note: 

	In some cases, these simple executions won't work. For e.g.
	document.getElementById("p1").innerHTML = "Hey there " + firstName;
	document.getElementById("p2").innerHTML = "You are " + age + " years old.";
	document.getElementById("p3").innerHTML = "Enrollment status: " + isStudent;

	They are likely to throw out an error
	|--> Uncaught TypeError: Cannot set properties of null (setting 'innerHTML')

	This happens because
	|--> you are trying to set the innerHTML property of an element that doesn't exist or is null. 
	|--> JavaScript code runs before the HTML elements are fully loaded
	|--> or when there's a mismatch between the element's ID in your JavaScript code and the actual HTML.
*/

// To change the innerHTML use 
document.addEventListener('DOMContentLoaded', function() {
	document.getElementById("p1").innerHTML = "Hey there " + firstName;
	document.getElementById("p2").innerHTML = "You are " + age + " years old.";
	document.getElementById("p3").innerHTML = "Enrollment status: " + isStudent;
});

/*
	|--> A document object represents the HTML document that is displayed in that window.
	|--> .addEventListener() method allows to register an event listener on an HTML element.
	|--> DOMContentLoaded is the type of event you want to listen for.
	|--> function() { //Code } is an anonymous JavaScript function that serves as the event handler.
	|--> .getElementById() method allows to retrieve a reference to an HTML element by its unique ID attribute.
	|--> .innerHTML is a property of the HTML element that represents the content within the element.
*/
