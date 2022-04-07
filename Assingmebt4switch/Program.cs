// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the operator you choose");
char opert = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Enter 1st number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
int num2 = Convert.ToInt32(Console.ReadLine());
int result;
switch(opert)
{
    case '+':
        result = num1 + num2;
        Console.WriteLine("Sum of two number is="+result);
        break;
    case '-':
        result = num1 - num2;
        Console.WriteLine("Subsraction of two number is ="+result);
        break;
    case '*':
        result = num1 * num2;
        Console.WriteLine("Multiplication of two number is =" + result);
        break;
    case '/':
        result = num1 / num2;
        Console.WriteLine("Division of two number is =" + result);
        break;

}
