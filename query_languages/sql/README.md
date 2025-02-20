# SQL

SQL or Structured Query Language is a query programming language for managing RDBMS i.e. Relational Database Management System).

1. Database 

   In a database, tables are used to organize and store data, similar to how files are organized within a folder. Just as you can have multiple files within a folder, a database can contain multiple tables, each storing different types of data.

   <i><ins>Note:</ins> SQL commands should be ended by a semicolon `;` symbol.</i>

2. Creating a database

   ```
   CREATE DATABASE myDB;
   ```

3. Accessing a database

   ```
   USE myDB;
   ```

4. Deleting a database

   ```
   DROP DATABASE myDB;
   ```

5. Altering a database

   - Setting database to read only:

     If the database is in read-only mode, we can't make any modifications to it but we can still access the data within.

     ```
     ALTER DATABASE myDB READ ONLY = 1;
     ```

     In this case, let's say we tried to drop the database. This will return `Error Code: 3989. Schema 'mydb' is in read only mode` as the database has been set to read only. To disable read only, we can set the value to `0`.

   - Enabling encryption:

     ```

     ```

6. Tables

   A table in a RDBMS consist of rows and columns, like an Excel spreadsheet.

7. Creating a table

   ```
   CREATE TABLE employees (
      employee_id INT,
       first_name VARCHAR(50),
       last_name VARCHAR(50),
       hourly_pay DECIMAL(5, 2),
       hire_date DATE
   );
   ```
   
   - Syntax: `CREATE TABLE <table-name> ();`
   - Within parenthesis, we will list the columns (or attributes).
   - Each column is followed by its respective data type.
   - Each column is separated by a comma.

8. Selecting a table

   `SELECT` is also used for querying.

   ```
   SELECT * FROM employees;
   ```

9. Renaming a table

   ```
   RENAME TABLE employees to workers;
   ```

   <i><ins>Note:</ins> use `RENAME TABLE workers TO employees;` to revert back.</i>

10. Deleting a table

    ```
    DROP TABLE employees;
    ```

11. Altering a table

    We can use `ALTER` to edit/alter the table.

    - Adding a column:

      `ADD` to add a new column i.e. `phone_number`.

      ```
      ALTER TABLE employees
      ADD phone_number VARCHAR(15);
      ```
    - Renaming a column:

      `RENAME COLUMN <old-name> TO <new-name>` to rename column.

      ```
      ALTER TABLE employees
      RENAME COLUMN phone_number TO email;
      ```

    - Modifying a column:

      `MODIFY COLUMN <column-name> <data-type>` to modify datatype of a column.

      ```
      ALTER TABLE employees
      MODIFY COLUMN email VARCHAR(100);
      ```

    - Changing position of a column:

      `AFTER` to change position of a column.

      ```
      ALTER TABLE employees
      MODIFY COLUMN email VARCHAR(100)
      AFTER last_name;
      ```
    - Changing position of a column to first:

      `FIRST` to change position of a column to first.

      ```
      ALTER TABLE employees
      MODIFY COLUMN email VARCHAR(100)
      FIRST;
      ```

    - Deleting a column:

      ```
      ALTER TABLE employees
      DROP COLUMN email;
      ```

12. Inserting a row into the table

    - Syntax:

      ```
      INSERT INTO <table-name>
      VALUES (value_1, value_2, value_3, ...);
      ```

    - Example:

      ```
      INSERT INTO employees
      VALUES (1, "Eugene", "Krabs", 25.50, "2023-01-02");
      ```

      Date format: `YYYY-MM-DD`

13. Inserting multiple rows into the table
   
    - Syntax: 

      ```
      INSERT INTO <table-name>
      VALUES (), (), (), ();
      ```

      <i><ins>Note:</ins> Number of brackets are equivalent to number of rows that you want to insert.</i>

    - Example: 

      ```
      INSERT INTO employees
      VALUES (2, "Squidward", "Tentacles", 21.99, "2023-03-04"),
             (3, "Spongebob", "Squarepants", 22.67, "2022-05-06"),
             (4, "Patrick", "Star", 26.42, "2021-07-08"),
             (5, "Sandy", "Cheeks", 29.82, "2020-09-12");
      ```

14. Inserting row with "missing" data

    ```
    INSERT INTO employees
    VALUES (6, "Sheldon", "Plankton");
    ```

    Results in `Error Code: 1136. Column count doesn't match value count at row 1`.

    One way to deal with it is to add data to only selected columns.

    Example:

    ```
    INSERT INTO employees (employee_id, first_name, last_name)
    VALUES (6, "Sheldon", "Plankton");
    ```

15. SELECT STATEMENT

    `SELECT` statement is used to query data.

    - Use `*` to select all columns.

      ```
      SELECT * FROM employees;
      ```

    - Use specific column names to select particular columns.

      ```
      SELECT first_name, last_name 
      FROM employees;
      ```

    - Changing order of columns:

      ```
      SELECT hire_date, first_name, last_name 
      FROM employees;
      ```

    - WHERE Clause:

      Use `WHERE` clause when you are looking for something specific.

      - Syntax:

        ```
        SELECT *
        FROM <table-name>
        WHERE <condition>;
        ```

      - Example 1:

        ```
        SELECT *
        FROM employees
        WHERE employee_id = 1;
        ```

      - Example 2:

        ```
        SELECT *
        FROM employees
        WHERE first_name = "Spongebob";
        ```

      - Example 3:

        ```
        SELECT *
        FROM employees
        WHERE hourly_pay >= 25;
        ```

      - Example 4:

        ```
        SELECT *
        FROM employees
        WHERE hire_date <= "2023-01-03";
        ```

    - NOT COMPARISON OPERATOR (not equal)

      OPERATOR --> `!=`

      ```
      SELECT *
      FROM employees
      WHERE employee_id != 1;
      ```

    - Selecting rows which have `NULL` values

      Use `IS NULL` with `WHERE` clause.

      ```
      SELECT *
      FROM employees
      WHERE hire_date IS NULL;
      ```

      <i><ins>Note:</ins> Contrary usage --> `IS NOT NULL`. It would return every row that doesn't have `NULL` data.</i>

16. Updating data in table

    Use `UPDATE` statement for updating data in a table. 

    - Syntax:

      ```
      UPDATE <table-name>
      SET <column-name> = value
      WHERE <condition>;
      ```

    - Example 1:

      ```
      UPDATE employees
      SET hourly_pay = 18.76, hire_date = "2024-01-27"
      WHERE employee_id = 6;
      ```

    - Example 2: (setting hire_date as `NULL`)

      ```
      UPDATE employees
      SET hire_date = NULL
      WHERE employee_id = 6;
      ```

17. Deleting data in table

    Use `DELETE` statement for deleting row in a table. 

    - Syntax:

      ```
      DELETE FROM <table-name>
      WHERE <condition>;
      ```

    - Example 1:

      ```
      DELETE FROM employees
      WHERE employee_id = 6;
      ```

18. AUTOCOMMIT, COMMIT, and ROLLBACK
    
    - Autocommit is a feature in database systems where each SQL statement is automatically committed immediately after it is executed. This means that each individual SQL statement is treated as a transaction by itself, and it is automatically committed to the database. It can be turned off using `SET AUTOCOMMIT = OFF;`.

    - Commit is an SQL statement that finalizes the changes made in a transaction and makes those changes permanent in the database. When you issue a commit statement, all the changes made within the transaction are saved to the database. Syntax: `COMMIT;`.

    - Rollback is an SQL statement that undoes the changes made in the current transaction and restores the database to its state before the transaction began. Syntax: `ROLLBACK;`.

19. CURRENT_DATE() & CURRENT_TIME()

    In SQL, `CURRENT_DATE()` and `CURRENT_TIME()` are functions that return the current date and time, respectively, based on the system clock of the server where the database is hosted.

    ```
    CREATE TABLE test(
      my_date DATE,
      my_time TIME,
      my_datetime DATETIME
    );

    INSERT INTO test
    VALUES (CURRENT_DATE(), CURRENT_TIME(), NOW());
    ```

    In SQL, `NOW()` is a function that returns the current date and time together.

    If you put -1 or +1 after CURRENT_DATE() in SQL, you are performing date arithmetic to subtract or add days to the current date.

    For e.g.

    ```
    SELECT CURRENT_DATE() - 1;
    ```

    This would subtract one day from the current date.

    ```
    SELECT CURRENT_DATE() + 1;
    ```

    This would add one day to the current date.

20. UNIQUE CONSTRAINT

    `UNIQUE` constraint ensures that all the values in a column are different. This constraint can be added while creating the table or after the table has been created.

    ```
    CREATE TABLE products (
       product_id INT,
       product_name VARCHAR(25) UNIQUE,
       price DECIMAL(4, 2)
    );
    ```

    Adding `UNIQUE` constraint after creating the table

    ```
    ALTER TABLE products
    ADD CONSTRAINT
    UNIQUE(<column-nmae>);
    ```

    <i><ins>Note:</ins> Don't forget to replace `<column-name>` with actual column name.</i>

    ```
    ALTER TABLE products
    ADD CONSTRAINT
    UNIQUE(product_name);
    ```

    Since, `product_name` is already unique, this will return `1 warning(s): 1831 Duplicate index 'product_name_2' defined on the table 'mydb.products'`.

    As, `UNIQUE` doesn't allow duplicate values, trying out something like this:

    ```
    INSERT INTO products
    VALUES   (100, "hamburger", 3.99),
             (101, "fries", 1.89),
             (102, "soda", 1.00),
             (103, "ice cream", 1.49)
             (104, "fries", 1.75);
    ```

    might give an error - `Error Code: 1064. You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '(104, "fries", 1.75)' at line 6`.

21. NOT NULL CONSTRAINT

    `NOT NULL` constraint doesn't allows a column value to be NULL.

    ```
    CREATE TABLE products (
       product_id INT,
       product_name VARCHAR(25) UNIQUE,
       price DECIMAL(4, 2) NOT NULL
    );
    ```

    Adding the `NOT NULL` constraint after creating the table. (Note: Use `MODIFY`)

    ```
    ALTER TABLE products
    MODIFY price DECIMAL(4,2) NOT NULL;
    ```

    So, inserting any NULL values in the column might give an error - `Error Code: 1048. Column 'price' cannot be null`. For e.g.

    ```
    INSERT INTO products
    VALUES (104, "cookies", NULL);
    ```

22. CHECK CONSTRAINT

    `CHECK` constraint is a type of constraint that allows you to specify a condition that each row in a table must satisfy for any update or insertion to be accepted.

    ```
    CREATE TABLE table_name (
       column1 datatype,
       column2 datatype,
       ...
       CHECK (condition)
    );
    ```

    If you have some later plans for the `CHECK` constraint like deleting or modifying it, then add a constraint name to it.

    ```
    CREATE TABLE table_name (
       column1 datatype,
       column2 datatype,
       ...
       CONSTRAINT constraint_name CHECK (condition)
    );
    ```

    Adding `CHECK` constraint after the table has been created:

    ```
    ALTER TABLE table_name
    ADD CONSTRAINT constraint_name CHECK (condition);
    ```

    Dropping a `CHECK` constraint:

    ```
    ALTER TABLE table_name
    DROP CONSTRAINT constraint_name;
    ```

    Let's implement an hourly pay check in the following example...

    ```
    ALTER TABLE employees
    ADD CONSTRAINT chk_hourly_pay CHECK (hourly_pay >= 10.00);
    ```

    Inserting a row while `CHECK` constraint has been implemented. For e.g.

    ```
    INSERT INTO employees
    VALUES (6, "Sheldon", "Planks", 5.00, "2023-01-07");
    ```

    <i><ins>Note:</ins> The above implementation will give an error - `Error Code: 3819. Check constraint 'chk_hourly_pay' is violated` as the value for `hourly_pay` should be greater than or equal to 10.</i>

23. DEFAULT CONSTRAINT

    The DEFAULT constraint is used to set a default value for a column.

    The default value will be added to all new records, if no other value is specified.

    - Creating a table

      ```
      CREATE TABLE products (
         product_id INT,
         product_name VARCHAR(25),
         price DECIMAL(4,2) DEFAULT 0
      );
      ```

    - Alter a table

      ```
      ALTER TABLE products
      ALTER price SET DEFAULT 0;
      ```

    - Inserting data in tables requires user to mention columns explicitly otherwise this error is returned - `Error Code: 1136. Column count doesn't match value count at row 1`.

      ```
      INSERT INTO products (product_id, product_name)
      VALUES   (104, "straw"),
               (105, "napkin"),
               (106, "fork"),
               (107, "spoon");

      SELECT * FROM products;
      ```

      <table>
         <tr>
            <th>product_id</th>
            <th>product_name</th>
            <th>price</th>
         </tr>
         <tr>
            <td>100</td>
            <td>hamburger</td>
            <td>3.99</td>
         </tr>
         <tr>
            <td>101</td>
            <td>fries</td>
            <td>1.89</td>
         </tr>
         <tr>
            <td>102</td>
            <td>soda</td>
            <td>1.00</td>
         </tr>
         <tr>
            <td>103</td>
            <td>ice cream</td>
            <td>1.49</td>
         </tr>
         <tr>
            <td>104</td>
            <td>straw</td>
            <td>0.00</td>
         </tr>
         <tr>
            <td>105</td>
            <td>napkin</td>
            <td>0.00</td>
         </tr>
         <tr>
            <td>106</td>
            <td>fork</td>
            <td>0.00</td>
         </tr>
         <tr>
            <td>107</td>
            <td>spoon</td>
            <td>0.00</td>
         </tr>
      </table>

    - Example:

      Let's say we have a table of transactions. After inserting a new transaction, we will insert a time stamp of when that transaction took place and that time stamp would be DEFAULT.

      - Creating the table
         
        ```
        CREATE TABLE transactions(
            transaction_id INT,
            amount DECIMAL(5, 2),
            transaction_date DATETIME DEFAULT NOW()
        );
        ```

      - Inserting data into the table
         
        ```
        INSERT INTO transactions (transaction_id, amount)
        VALUES  (1, 4.99),
                (2, 3.67),
                (3, 5.23);
        ```

        <table>
         <tr>
            <th>transaction_id</th>
            <th>amount</th>
            <th>transaction_date</th>
         </tr>
         <tr>
            <td>1</td>
            <td>4.99</td>
            <td>2024-02-29 17:36:47</td>
         </tr>
         <tr>
            <td>2</td>
            <td>3.67</td>
            <td>2024-02-29 17:36:47</td>
         </tr>
         <tr>
            <td>3</td>
            <td>5.23</td>
            <td>2024-02-29 17:36:47</td>
         </tr>      
        </table>

24. PRIMARY KEY CONSTRAINT

    `PRIMARY KEY` constraint can be applied to a column where each value in that column must both be unique and not null.

    It is typically used as a unique identifier.

    The `PRIMARY KEY` constraint uniquely identifies each record in a table.

    Imagine you have a table students with the following columns:

    - `student_id` (Primary Key)
    - `first_name`
    - `last_name`
    - `date_of_birth`

    The student_id column serves as the primary key. Think of it like a unique identifier for each student in the school. Just like how every student in a school might have a unique student ID number, in a database, the student_id ensures that each student's record is unique and identifiable.

    For example:

    <table>
       <tr>
         <th>student_id</th>
         <th>first_name</th>
         <th>last_name</th>
         <th>date_of_birth</th>
       </tr>
       <tr>
         <td>1</td>
         <td>John</td>
         <td>Doe</td>
         <td>2002-05-15</td>
       </tr>
       <tr>
         <td>2</td>
         <td>Jane</td>
         <td>Smith</td>
         <td>2003-08-22</td>
       </tr>
       <tr>
         <td>3</td>
         <td>Michael</td>
         <td>Johnson</td>
         <td>2002-11-30</td>
       </tr>
    </table> 