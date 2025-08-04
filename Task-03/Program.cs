// SOLUTION TO QUESTION 1

/*
A. Loop Type: For-Loop
Reason: Because I know exactly how many times to repeat (100 times).

B. Loop Type: Do-While Loop
Reason: The user must enter input at least once before checking if it’s correct.

C. Loop Type: While Loop
Reason: You don’t know the number of items ahead of time; it keeps running until no more items remain.

D. A while loop checks the condition before running the block. A do-while loop checks the condition after running the block at least once.

*/


// SOLUTION TO QUESTION 2

/*
A. A method is a block of code that does a specific job. You can call it by name to run that code whenever you need.

B. The DRY principle means you shouldn’t write the same code over and over. Methods help you follow DRY by putting repeated code in one place so you can reuse it easily.
*/

// SOLUTION TO QUESTION 2C
static void PrintApplicationHeader()
{
    Console.WriteLine("=== My Awesome App ===\r\n\r\n======================\n");
}

PrintApplicationHeader();


// SOLUTION TO QUESTION 3

int counter = 5;
while (counter > 0)
{
    Console.WriteLine($"{counter}");
    counter--;
}
Console.WriteLine("Loop finished!\n");


// SOLUTION TO QUESTION 4
static void DisplayUserInformarion(string name, int age)
{
       Console.WriteLine($"Hello {name}!, You are {age} years old\n");
}


DisplayUserInformarion("Samuel", 20);
DisplayUserInformarion("Temitope", 37);

/* SOLUTION TO QUESTION 4C
A parameter is a variable listed in a method's definition that allows you to pass information into the method. 
It is useful because it makes the method flexible and reusable with different input values.
*/


// SOLUTION TO QUESTION 5
static double CalculateRectangleArea(double length, double width)
{
    return length * width;
}

double area = CalculateRectangleArea(7.0, 3.5);

Console.WriteLine($"The rectangle area is: {area}");


/*
 The return keyword ends the method and sends a value back to the caller.
It has two main effects: it stops the method’s execution and provides the result.
 */