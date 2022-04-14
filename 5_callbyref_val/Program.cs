Console.WriteLine("=============================================");
Console.WriteLine("\t\t\tCall by reference");
void myFunc(ref int a)
{
    a = 50;
}

int a = 20;
myFunc(ref a);
Console.WriteLine(a);

Console.WriteLine("=============================================");
Console.WriteLine("\t\t\tCall by value");

void myFunc2(int b)
{
    b = 50;
}
int b = 20;
myFunc2(b);
Console.WriteLine(b);
Console.WriteLine("=============================================");
