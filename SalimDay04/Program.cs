//B b = new B();
////b.display();
//b.displayB();

//A aa = new B();   // 
////aa.display();
////aa.displayB();

//class A
//{ 
//    protected void display()
//    {
//        Console.WriteLine("A");
//    }
//}

//class B : A
//{
//    public void displayB()
//    {
//        Console.WriteLine("B");
//        display();
//    }
//}

//Console.WriteLine("========================================================================================");
AB ab1 = new AB();
AB ab2 = new AB();
AB ab3 = new AB();
AB ab4 = new AB();
AB ab5 = new AB();
Console.WriteLine("Counts : " + AB.cnt);

class AB
{
    public static int cnt=0;
    public AB() 
    {
        cnt++;
    }

    //public static displayObj()
    //{

    //}
}

