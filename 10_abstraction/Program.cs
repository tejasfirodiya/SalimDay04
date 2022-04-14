//Abstraction:-
//        -1. jar ekhadi method abstract asel tar tya method cha class pn abstract pahije
//        -2. abstract method declare kartana body nahi takaychi.(parent mdhe declaration)
//        -3. abstract method fakt child madhe override hote using override keyword.(child madhe defination)
//        -4. abstract method declare and define kartana method_name same pahije.
//        -5. abstract method minimum ekda tari override zali pahij.if override nahi keli tar run time error yeil.
//        -6. abstract class cha object create nahi hot.
//        -7. abstract class is combination of abstract method and normal method.



//Console.WriteLine("==========================================================");

Animal aa = new Dog();
aa.sound();
aa.Show();

Animal aaa = new Cow();
aaa.sound();
aaa.Show();

abstract class Animal
{
    public abstract void sound();

    public void Show()
    {
        Console.WriteLine("Hello");
    }
}

class Dog : Animal
{
    public override void sound()
    {
        Console.WriteLine("bho");
    }

    public void Show()
    {
        Console.WriteLine("Dog Hello");
    }

    public void eat()
    {
        Console.WriteLine("Dog eating");
    }
}

class Cow : Animal
{
    public override void sound()
    {
        Console.WriteLine("Something diff");
    }

    public void Show()
    {
        Console.WriteLine("Cow Hello");
    }
    public void eat()
    {
        Console.WriteLine("cow eating");
    }
}
//Console.WriteLine("==========================================================");

