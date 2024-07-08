// See https://aka.ms/new-console-template for more information
using StringCalculatorCS;

try
{
    Console.WriteLine("Sum: "+StringCalculator.Add("1,2,3,1001"));
    Console.WriteLine("Sum: "+StringCalculator.Add("//;\n1;2,3,1001"));
    Console.WriteLine("Sum: " + StringCalculator.Add("//[;]\n1;2,3,1001"));
    Console.WriteLine("Sum: " + StringCalculator.Add("//[;]\n1;2,3,1001"));
    Console.WriteLine("Sum: " + StringCalculator.Add("//[;][pp]\n1;2pp3,1001"));
    Console.WriteLine("Sum: " + StringCalculator.Add("//[*][%%%%%%%%%%%%%%%%%%%%]\n1*2%%%%%%%%%%%%%%%%%%%%3"));
    //Console.WriteLine("Sum: "+StringCalculator.Add("//;\n-1;-2,5\n7"));
    //Console.WriteLine("Sum: " + StringCalculator.Add("//;\n1;,2"));
}
catch (NegativesNoAllowedException ex)
{

    Console.WriteLine(ex.Message);
}
catch (InvalidInputException ex)
{ 
    Console.WriteLine(ex.Message);
}
