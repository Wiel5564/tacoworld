// future: specification
// check: movable SQL Server Object Explorer, choose Data Source
// using System is Console namespace class. class being static keeps it around. void returns nothing. Main() is the starting method.
// .cs ett program, .sln flera, .csp projekt, \t tab, $@, $ stränginterpolation
Console.WriteLine("How many tacos do you need?");

string input = Console.ReadLine(); // klass Console, metod ReadLine(), en sats slutar med ;

int heltal = int.Parse(input); // converts into int, strings can't cast as (int)
// float och double är decimal, vat implicit typifierar

bool moreTacosBeingBetter = true;
Console.WriteLine("Are " + heltal + " tacos better than " + (heltal-1) + "?");
if (moreTacosBeingBetter == true)
{
    Console.WriteLine("Yes.");
}
else
{
    Console.WriteLine("No.");
}