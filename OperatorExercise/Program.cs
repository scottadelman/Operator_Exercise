Console.WriteLine("Enter simple equation below");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int quotient = a / b;
int remainder = a % b;

Console.WriteLine("Your answer is... " + quotient + " with a remainder of " + remainder);