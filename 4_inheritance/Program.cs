//Console.WriteLine("=======================================================================");

//Console.WriteLine("\t\t\tSingle Inheritence");

//Wxp1 wx1 = new Wxp1();
//wx1.display();
//wx1.Access();

//Wxp2 wx2 = new Wxp2();
//wx2.Access();
//wx2.display();
//wx2.Camera();

//Wxp1 wx3 = new Wxp2();  //reference_type object_name = new 
//wx3.display();
//wx3.Access();

//class Wxp1
//{

//    public void display()
//    {
//        Console.WriteLine("Display");
//    }

//    public void Access()
//    {
//        Console.WriteLine("Access");
//    }
//}

//class Wxp2 : Wxp1
//{
//    public void Camera()
//    {
//        Console.WriteLine("Camera");
//    }
//}

//Console.WriteLine("=======================================================================");

Console.WriteLine("\t\t\tMultilevel Inheritence");
A a = new A();
a.AShow();

B b = new B();
b.BShow();
b.AShow();

C c = new C();
c.CShow();
c.AShow();
c.BShow();

B c1 = new C();
c1.AShow();
c1.BShow();

class A
{
    public void AShow()
    {
        Console.WriteLine("AShow");
    }
}

class B:A
{
    public void BShow()
    {
        Console.WriteLine("BShow");
        AShow();
    }
}

class C:B
{
    public void CShow()
    {
        Console.WriteLine("CShow");
        AShow();
        BShow();
    }
}
