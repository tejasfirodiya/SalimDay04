////interface :-
////    -1.compulsory calling of all methods
////    -2.compulsory public access specifier
////    -3.only method declaration not defination
////    -4.interface mdhe ashya methods astat jyanchi body aaplyala mahiti naste ki tyat kay asel.
////    -5. Syntax :
////    interface interface_name { public void display(); }
////    -6.interface cha object create hot nahi
////    -7.

//abc a = new Student();

//interface abc
//{
//    public void display();
//}

//interface xyz
//{
//    public void display1();
//}

//class Student : abc,xyz
//{
//    public void display()
//    {
//        Console.WriteLine("Hello");
//    }

//    public void display1()
//    {
//        Console.WriteLine("Hello");
//    }
//}

//Console.WriteLine("=======================================================");
Animal c = new Cow();
c.Behaviour();
c.Sound();

Animal2 c1 = new Cow();
c1.abc();

Animal d = new Dog();
d.Behaviour();
d.Sound();

Animal cc = new Cat();
cc.Behaviour();
cc.Sound();

interface Animal2
{
    public void abc();
}

interface Animal
{
    public void Sound();
    public void Behaviour();
}

class Cow : Animal, Animal2
{
    public void abc()
    {
        Console.WriteLine("Second Interface");
    }

    public void Behaviour()
    {
        Console.WriteLine("Milk");
    }

    public void Sound()
    {
        Console.WriteLine("Hambaaa");
    }
}

class Dog : Animal
{
    public void Behaviour()
    {
        Console.WriteLine("Loyal");
    }

    public void Sound()
    {
        Console.WriteLine("Barking");
    }
}

class Cat : Animal
{
    public void Behaviour()
    {
        Console.WriteLine("Poor");
    }

    public void Sound()
    {
        Console.WriteLine("Meow");
    }
}