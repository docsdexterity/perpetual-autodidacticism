# Flutter

### Programming Fundamentals

- Variables allow to store different types of information.
  ```dart
    String name = "Sebastian";
    int age = 21;
    double pi = 3.14159;
    bool isBeginner = true;
  ```

- BASIC MATH OPERATORS
  ```dart
    4 + 4 = 8, add
    5 - 3 = 2, subtract
    2 * 3 = 6, multiply
    9 / 3 = 3, divide
    9 % 4 = 1, remainder
    ++, increment by one
    --, decrement by one
  ```

- COMPARISON OPERATORS
  ```dart
    5 == 5 -> true,   EQUAL TO
    2 != 3 -> true,   NOT EQUAL TO
    3 > 2  -> true,   GREATER THAN
    3 < 2  -> false,  LESS THAN
    5 >= 5 -> true,   GREATER OR EQUAL TO
    3 <= 7 -> true,   LESS OR EQUAL TO 
  ```

- LOGICAL OPERATORS
    - AND operator, returns true if both sides are true
      ```dart
        isBeginner && ( age < 18 ) -> returns false
      ```
    - OR operator, returns true if at least one side is true
      ```dart
        isBeginner || ( age < 18 ) -> returns true
      ```
    - NOT operator, returns the opposite value
      ```dart
        !isBeginner -> returns false
      ```
- CONTROL FLOW
    - IF statement
      ```dart
        // structure
        if (condition) {
          do something
        }

        // example
        if (age < 18) {
          print("Grow Up!!!");
        }
      ```
    - IF ELSE-IF statement
      ```dart
        // structure
        if (condition) {
          do something
        } else if (another condition) {
          do something else
        } else {
          do something else
        }

        // example
        if (age < 13) {
          print("You can only watch G rated movies.");
        } else if (age < 18) {
          print("You can only watch G and PG13 rated movies.");
        } else {
          print("You can watch G, PG13 and R rated movies.");
        }
      ```
    - IF ELSE statement
      ```dart
        // structure
        if (condition) {
          do something
        } else {
          do something else
        }

        // example
        if (age >= 18) {
          print("You are an adult.");
        } else {
          print("You are not an adult.");
        }
      ```
      
- SWITCH STATEMENT
  
  Instead of using repetitive if statements, for e.g. a grading system, a switch statement can be used as better alternative. 
  ```dart
    // structure
    switch (expression) {
      case value:
        break;
      default:
    }

    // example
    switch (grade) {
      case "A":
        print("Excellent!");
        break;
      case "B":
        print("Good!");
        break;
      case "C":
        print("Fair!");
        break;
      case "D":
        print("Needs Improvement!");
        break;
      default:
        print("Invalid Grade");
    }
  ```

- LOOPS
    - FOR loop
      
      Imagine you have a box of 10 different colored crayons and you want to draw a circle with each one. Instead of saying, "Draw a circle with the 1st crayon, then draw a circle with the 2nd crayon, etc...". It's much easier to say, "For each crayon in the box, draw a circle".
      ```dart
        // structure
        for (initialization; condition; iteration) {
          statement to be executed;
        }

        // example 1
        for (int i = 0; i <= 5; i++) {
          print(i);
        }

        // example 2
        for (int i = 0; i <= 8; i++) {
          if (i == 6) { // checking condition that breaks the loop when i = 6
            break;
          }
          print(i);
        }

        // example 3
        for (int i = 0; i <= 8; i++) {
          if (i == 6) { // 'continue' skips the current iteration i.e. printing 6
            continue;
          }
          print(i);
        }

        break -> break out of loop
        continue -> skip the current iteration
      ```
      
    - WHILE loop

      In a for loop, you have to specify the number of times to loop. If you don't know how many times to loop, you can use a while loop to keep looping until a certain condition is met.
      ```dart
      // structure
      while ( condition ) {
        statement to be executed;
        something here should modify the condition above;
      }

      // example
      int countDown = 5;

      while (countDown > 0) {
        print(countDown);
        countDown--;
      }
      ```
      
- FUNCTIONS / METHODS
  
  We can write codeblocks to get certain things done. Apparently, we can organize these blocks of code into functions so that we can reuse them easily.

  'void' means that the function returns nothing. They just execute the code in the function.

  ```dart
  // basic greet function
  void greet() {
    print("Hello!");
  }

  // function with parameters
  void greetUser(String name) {
    print("Hello " + name);
  }

  // function with return type
  int add(int a, int b) {
    int sum = a + b;
    return sum;
  }

  @override
  Widget build(BuildContext context) {

    greet();
    greetUser("Alex");
    int mySum = add(3, 5);
    print(mySum);

    return const MaterialApp(
      debugShowCheckedModeBanner: false,
      home: Scaffold(),
    );
  }
  ```

- DATA STRUCTURES
    - LIST

      Ordered collection of elements, can have duplicates.
      ```dart
        List numbers = [1, 2, 3];

        // numbers[0] -> 1
        // numbers[1] -> 2
        // numbers[2] -> 3

        void printNumbers() {
          for (int i = 0; i < numbers.length; i++) {
            print(numbers[i]);
          }
        }

        // We can also define particular datatypes for LIST. For e.g.
        List<int> numbers = [1, 2, 3];
        List<String> names = ["Alex", "Johan", "Tenma"];

        // names[0] -> Alex
        // names[1] -> Johan
        // names[3] -> Tenma
              
        void printNames() {
          for (int i = 0; i < names.length; i++) {
            print(names[i]);
          }
        }
      ```
    - SET

      Unordered collection of unique elements
      ```dart
        Set<String> uniqueNames = {"Dazai", "Ango", "Odasaku"};
      
        // for printing the set
        print(uniqueNames);
      ```
    - MAP

      Stored as key-value pairs
      ```dart
        Map user = {
          'name': "Alex",
          'age': 27,
          'height': 175,
        };
      
        // user['name'] -> Alex
        // user['age'] -> 27
        // user['height'] -> 175
      ```

### Everything is a Widget in Flutter

- DEBUG BANNER
  
  This banner is intended to deter people from complaining that your app is slow when it's in debug mode. In debug mode, Flutter enables a large number of expensive diagnostics to aid in development, and so performance in debug mode is not representative of what will happen in release mode.

  ```dart
    debugShowCheckedModeBanner: false
  ```
  
- SCAFFOLD

  Implements the basic Material Design visual layout structure.

  ```dart
    home: Scaffold(
        backgroundColor: Colors.deepPurple[200],
        // contains other properties as well 
    )
  ```
  
- CONTAINER

  While, scaffolding will alter the appearance and feel of Material on screen. A basic/common widget in Flutter called a container will hold other widgets.

  ```dart
    body: Center(
        child: Container(
        height: 300,
        width: 300,

        // color cannot be used outside of 'decoration'
        // color: Colors.deepPurple,

        // for decorations
        decoration: BoxDecoration(
            color: Colors.deepPurple,
            // for further decorations, we can curver the corners a bit
            borderRadius: BorderRadius.circular(20),
        ),

        padding: EdgeInsets.all(25),
        // padding: EdgeInsets.symmetric(horizontal: 25, vertical: 50),
        // padding: EdgeInsets.only(left: 105, top: 70),

        child: Text("Osamu Dazai"), // child widget inside container
    )
  ```
  
- TEXT

  The Text widget displays a string of text with single style. The string might break across multiple lines or might all be displayed on the same line depending on the layout constraints.

  ```dart
    child: Text(
        "Osamu Dazai",
        style: TextStyle(
            color: Colors.white,
            fontSize: 28,
            fontWeight: FontWeight.bold,
    )), // child widget inside container
  ```
  
- What it looks like up until now?

  ```dart
  // ignore_for_file: prefer_const_constructors

  import 'package:flutter/material.dart';
  
  void main() {
    runApp(MyApp());
  }
  
  class MyApp extends StatelessWidget {
    const MyApp({super.key});
  
    @override
    Widget build(BuildContext context) {
      return MaterialApp(
        debugShowCheckedModeBanner: false,
        home: Scaffold(
          backgroundColor: Colors.deepPurple[200],
          body: Center(
            child: Container(
              height: 300,
              width: 300,
  
              // color cannot be used outside of 'decoration'
              // color: Colors.deepPurple,
  
              // for decorations
              decoration: BoxDecoration(
                color: Colors.deepPurple,
                // for further decorations, we can curver the corners a bit
                borderRadius: BorderRadius.circular(20),
              ),
  
              padding: EdgeInsets.all(25),
              // padding: EdgeInsets.symmetric(horizontal: 25, vertical: 50),
              // padding: EdgeInsets.only(left: 105, top: 70),
  
              child: Text("Osamu Dazai",
                  style: TextStyle(
                    color: Colors.white,
                    fontSize: 28,
                    fontWeight: FontWeight.w100,
                  )), // child widget inside container
            ), // Container
          ), // Center
        ), // Scaffold
      ); // MaterialApp
    }
  }
  ```
  ![oz](https://github.com/user-attachments/assets/ffc4e307-6b85-4968-82d7-413dd03355a4)

- ICONS

  ```dart
    child: Icon(
        Icons.logout,
        color: Colors.white,
        size: 64,
    )),
  ```
  
  ![ic](https://github.com/user-attachments/assets/ad700ccf-556f-47ff-9e46-bec90d031ee7)

- APPBAR

  ```dart
    appBar: AppBar(
              title: Text("My App Bar",
                  style: TextStyle(
                    color: Colors.white,
                  )),
              backgroundColor: Colors.black,
              elevation: 0,
              leading: Icon(Icons.menu, color: Colors.white),
              actions: [
                IconButton(
                    onPressed: () {},
                    icon: Icon(Icons.logout, color: Colors.white))
              ]),
  ```

- COLUMN / ROW

  ```dart
    body: Column(

            // -----------------------------------------------------------------

            // for column -> Column()
            // for row -> Row()

            // -----------------------------------------------------------------

            // mainAxisAlignment vs crossAxisAlignment

            /*
            When you use a Row, its children are laid out in a row, 
            which is horizontally. So a Row's main axis is horizontal. 
            Using mainAxisAlignment in a Row lets you align the row's 
            children horizontally (e.g. left, right). The cross axis to 
            a Row's main axis is vertical. So using crossAxisAlignment 
            in a Row lets you define, how its children are aligned 
            vertically.
            
            In a Column, it's the opposite. The children of a column are 
            laid out vertically, from top to bottom (per default). So its 
            main axis is vertical. This means, using mainAxisAlignment in 
            a Column aligns its children vertically (e.g. top, bottom) and 
            crossAxisAlignment defines how the children are aligned 
            horizontally in that Column.
            */

            // -----------------------------------------------------------------

            // mainAxisAlignment: MainAxisAlignment.center,
            // mainAxisAlignment: MainAxisAlignment.end,
            // mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            // mainAxisAlignment: MainAxisAlignment.spaceBetween,

            /*
            children: [
              Container(height: 200, width: 200, color: Colors.deepPurple),
              Container(height: 200, width: 200, color: Colors.deepPurple[400]),
              Container(height: 200, width: 200, color: Colors.deepPurple[600]),
            ],
            */

            // -----------------------------------------------------------------

            // crossAxisAlignment: CrossAxisAlignment.start,
            // crossAxisAlignment: CrossAxisAlignment.end,
            // crossAxisAlignment: CrossAxisAlignment.center,

            /*
            children: [
              Container(height: 300, width: 300, color: Colors.deepPurple),
              Container(height: 200, width: 200, color: Colors.deepPurple[400]),
              Container(height: 100, width: 100, color: Colors.deepPurple[200]),
            ],
            */

            // -----------------------------------------------------------------

            // Expanded Class

            /*
            Using an Expanded widget makes a child of a Row, Column, 
            or Flex expand to fill the available space along the main 
            axis (e.g., horizontally for a Row or vertically for a Column). 
            If multiple children are expanded, the available space is divided 
            among them according to the flex factor.
            */

            // Expanding only one child

            /*
            children: [
              Container(height: 200, width: 200, color: Colors.deepPurple),
              Container(height: 200, width: 200, color: Colors.deepPurple[400]),
              Expanded(
                  child: Container(width: 200, color: Colors.deepPurple[200])),
            ],
            */

            // Expamding all the child

            /*
            children: [
              Expanded(child: Container(width: 200, color: Colors.deepPurple)),
              Expanded(
                  child: Container(width: 200, color: Colors.deepPurple[400])),
              Expanded(
                  child: Container(width: 200, color: Colors.deepPurple[200])),
            ],
            */

            // If there is no height or width,
            // screen is divided in equal sections.

            /*
            children: [
              Expanded(child: Container(color: Colors.deepPurple)),
              Expanded(child: Container(color: Colors.deepPurple[400])),
              Expanded(child: Container(color: Colors.deepPurple[200])),
            ],
            */

            // Using flex property

            // --> Initial value is 1

            // flex tells the ration of current widget
            // in comparison to the other widgets

            children: [
              Expanded(child: Container(color: Colors.deepPurple)),
              Expanded(
                  flex: 2, child: Container(color: Colors.deepPurple[400])),
              Expanded(child: Container(color: Colors.deepPurple[200])),
            ],

            // -----------------------------------------------------------------
            
          ),
  ```

- LISTVIEW

  ```dart
    body: ListView(

            // -----------------------------------------------------------------

            // If the widget size is quite large, it is probable
            // that it might not fit all on the screen. This is
            // labelled as more of an overflow problem.

            // To counter this, we can use LISTVIEW instead of
            // COLUMN / ROW

            // -----------------------------------------------------------------

            // LISTVIEW is same as COLUMN / ROW but it also allows
            // to scroll, which means all of the children will fit.

            // -----------------------------------------------------------------

            // We can also control the scroll direction, which is
            // vertical, by default.

            // -----------------------------------------------------------------

            // for horizontal

            /*
            scrollDirection: Axis.horizontal,
            children: [
              Container(width: 500, color: Colors.deepPurple),
              Container(width: 500, color: Colors.deepPurple[400]),
              Container(width: 500, color: Colors.deepPurple[200]),
            ],
            */

            // -----------------------------------------------------------------

          ),
  ```

- ListView.builder()

  ```dart
    body: ListView.builder(

              /*
              The standard ListView constructor works well for small lists. 
              To work with lists that contain a large number of items, 
              it’s best to use the ListView.builder constructor.
              */ 

              itemCount: 100,
              itemBuilder: (context, index) =>
                  ListTile(title: Text(index.toString())),
            )
  ```

- GridView.builder()

  ```dart
    body: GridView.builder(
                itemCount: 200,
                gridDelegate: SliverGridDelegateWithFixedCrossAxisCount(
                    crossAxisCount: 8),
                itemBuilder: (context, index) => Container(
                      color: Colors.deepPurple,
                      margin: EdgeInsets.all(2),
                )
            )
  ```
  
  ![gv](https://github.com/user-attachments/assets/db503062-1e9b-4ecc-b78e-ebecf3d569ff)

- STACK

  ```dart
    body: Center(
              child: Stack(
                // stacks different widgets on top of each other
                //alignment: Alignment.center,
                //alignment: Alignment.bottomRight,
                children: [
                  // big box
                  Container(
                    height: 300,
                    width: 300,
                    color: Colors.deepPurple,
                  ),
                  // medium box
                  Container(
                    height: 200,
                    width: 200,
                    color: Colors.deepPurple[400],
                  ),
                  // small box
                  Container(
                    height: 100,
                    width: 100,
                    color: Colors.deepPurple[100],
                  ),
                ],
              ),
            )
  ```

  ![st](https://github.com/user-attachments/assets/3d2f43a3-abbb-4ec5-aa4f-13e4285755cb)

- GESTURE DETECTOR

  ```dart
    body: Center(
              child: GestureDetector(
                // detects gestures from user

                /*
                onTap: () {
                  print("User Tapped");
                },
                */

                onTap: userTapped,
                child: Container(
                  height: 300,
                  width: 300,
                  color: Colors.deepPurple[200],
                  child: Center(child: Text("Tap Me!")),
                ),
              ),
            )
  ```

  ![gd](https://github.com/user-attachments/assets/456d6bb0-c1af-4cb4-bc85-47adf18f59d0)
  
### Navigation (how to navigate to different screens)
### Stateless vs Stateful Widgets
### User Input
### To Do App (Saving data in phone's local storage)
### E-commerce App (Neccessary functionalities like adding items to the cart)
