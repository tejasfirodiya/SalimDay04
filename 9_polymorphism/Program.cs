////Polymorphism: one thing have more behaviours. 
////    there are two type of polymorphism :-
////        1. Overloading(compile time polymorphism)
////            - Overloading is in between single class
////        2. Overriding(run time polymorphism)
////            - Overriding is between two/more classes
///             - run time object tayar hotat(ji derived method aahe, ti kontya class mdhun derive hote he run time la samjat)
//Console.WriteLine("==============================================================================================");

////Console.WriteLine("\t\t\tOverloading");
//A a = new A();
//a.Show();        //compile time la object la mahitiye ki ya method la kiti parameters aahe. 
//a.Show(5,6);
//a.Show(5.6F);
//a.Show(5,5.7F);
//a.Show(5);

//class A
//{
//    public void Show()
//    {
//        Console.WriteLine("Showing");
//    }

//    public void Show(int a)
//    {
//        Console.WriteLine("Showing" + a);
//    }

//    public void Show(float b)
//    {
//        Console.WriteLine("Showing" + b);
//    }

//    public void Show(int a, int b)
//    {
//        Console.WriteLine("int a, int b");
//    }

//    public void Show(int a, float b)
//    {
//        Console.WriteLine("int a, float b");
//    }
//}
//Console.WriteLine("========================================================");
//Console.WriteLine("\t\t\Overriding");
//      - overriding madhe virtual and override keyword use kartat.
//      - jar IS-A relationship asel tar ch Override hote.
//      - parent class madhe virtual keyword use hoto
//      - child class madhe override keyword use hoto

//Animal a = new Animal();
//a.eat();

//Animal aa = new Dog();
//aa.eat();

//Animal aaa = new Cow();
//aaa.eat();

//class Animal
//{
//    public virtual void eat()
//    {
//        Console.WriteLine("eating style");
//    }
//}

//class Dog : Animal
//{
//    public override void eat()
//    {
//        //base.eat();
//        Console.WriteLine("Licking");
//    }
//}

//class Cow : Animal
//{
//    public override void eat()
//    {
//        //base.eat();
//        Console.WriteLine("Something diff");
//    }
//}

//Console.WriteLine("========================================================");

Dog dog = new Dog();
dog.eat();
Animal dog1 = new Dog();
dog1.eat();

class Animal
{
    public void eat()
    {
        Console.WriteLine("eating style");
    }
}

class Dog : Animal
{
    public void eat()
    {
        //base.eat();
        Console.WriteLine("Licking");
    }
}
//Console.WriteLine("========================================================");






