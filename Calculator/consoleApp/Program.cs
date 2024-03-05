using System.Globalization;

Console.WriteLine("--------------------------------------");
Console.WriteLine("CALCULATOR - made with by Reines5");
Console.WriteLine("--------------------------------------\n\n");


//Number 1 input
Console.WriteLine("--------------------------------------");
Console.Write("First number: ");
float number1 = Convert.ToSingle(Console.ReadLine());

//Number 2 input
Console.Write("Second number: ");
float number2 = Convert.ToSingle(Console.ReadLine());

//Number correction
Console.WriteLine($"First number is {number1}, second number is {number2}");
Console.WriteLine("--------------------------------------\n\n");

//Transaction selection
Console.WriteLine("--------------------------------------");
Console.Write("1) Addition \n2) Substraction \n3) Multiplication \n4) Division \nPlease select a transaction: ");
string transaction = Console.ReadLine().ToLower();

if ( transaction == "1" || transaction == "addition" ) {
    number1 += number2;
    Console.WriteLine("Answer: " + number1);
    Console.WriteLine("--------------------------------------");

} else if (transaction == "2" || transaction == "substraction" ) {
    number1 -= number2;    
    Console.WriteLine("Answer: " + number1);
    Console.WriteLine("--------------------------------------");

} else if (transaction == "3" || transaction == "multiplication" ) {
    number1 *= number2;
    Console.WriteLine("Answer: " + number1);
    Console.WriteLine("--------------------------------------");

} else if (transaction == "4" || transaction == "division" ) {
    number1 /= number2;
    Console.WriteLine("Answer: " + number1);
    Console.WriteLine("--------------------------------------");

} else if (transaction == "") {
    Console.WriteLine("WRONG SELECTION...");
    Console.WriteLine("--------------------------------------");

} else {
    Console.WriteLine("WRONG SELECTION...");
    Console.WriteLine("--------------------------------------");

}

Console.ReadKey();