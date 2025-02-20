/*
	User Input
		1. EASY WAY (with a window prompt)
		2. DIFFICULT WAY (with an HTML textbox)
*/

/*
	1. EASY WAY
	----------------------------------------------------------------------------------------------------------
	The prompt() method displays a dialog box that prompts the user for input
	The prompt() method returns the input value if the user clicks "OK", otherwise it returns null.
	let username = window.prompt("What's your name?");
	console.log(username); 
*/

/*
	2. DIFFICULT WAY
	-----------------------------------------------------------------------------------------------------------
	After clicking submit button, the text in input element is stored in a variable.

*/

document.addEventListener('DOMContentLoaded', function(){
	document.getElementById("myButton").onclick = function(){
		username = document.getElementById("myText").value;
		console.log(username);
		// Changing innerHTML
		document.getElementById("myLabel").innerHTML = "Hello " + username;
	};
});
