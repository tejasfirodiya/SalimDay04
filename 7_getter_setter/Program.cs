//Encapsulation : binding a data with function. 
//      - data will only be accessed by functions
//      - data must be private

//getter setter is a part of encapsulation.

//getter setter :
//1. to access private members outside the class
//2. jar ekhadya variable var limitation takaychya astil tar use karto.

//syntax : 
//class Student
//{
// eg. private string Name;
// public string NameInfo   //here NameInf is method name  //getter setter function he public astat
//{
//    get {
//        return this.Name;
//    }
//    set{ 
//        this.Name = value;
//    }
//}
//}

//getter setter call kasa karaycha? ==> by using method name of getter setter
//Student s = new Student();
//sbyte.NameInfo = "ithe value pass kara";
//Console.WriteLine(s.NameInfo);
//getter setter call kasa karaycha? ==> by using method name of getter setter

//Console.WriteLine("====================================================================");

//Student s = new Student();
//s.NameInfo = "ithe value pass kara";
//Console.WriteLine(s.NameInfo);
//class Student
//{
//     private string Name;
//    public string NameInfo   //here NameInf is method name  //getter setter function he public astat
//    {
//        get
//        {
//            return this.Name;
//        }
//        set
//        {
//            this.Name = value;
//        }
//    }
//}

//Console.WriteLine("====================================================================");


//Student s = new Student();
//s.NameInfo = "ithe value pass kara";
//Console.WriteLine(s.NameInfo);

Account acc = new Account(101010, "Tejas Firodiya", 999999, "Savings");
acc.display();
acc.Name = "Tejas Santosh Firodiya";
acc.Balance = 9898980000;
//acc.AccountNo = 45643463546;
acc.TypeOfAccount = "Current";
acc.display();

class Account
{
    long _accountNo;
    string _name;
    double _balance;
    string _typeOfAccount;

    public long AccountNo
    {
        get { return _accountNo; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public double Balance
    {
        get { return _balance; }
        set { _balance = value; }
    }

    public string TypeOfAccount
    {
        get { return _typeOfAccount; }
        set { _typeOfAccount = value; }
    }

    public Account(long accountNo, string name, double balance, string typeOfAccount)
    {
        this._accountNo = accountNo;
        this._name = name;
        this._balance = balance;
        this._typeOfAccount = typeOfAccount;
    }

    public void display()
    {
        Console.WriteLine($"Account No : {_accountNo}, Name : {_name}, Balance : {_balance}, Type Of Account : {_typeOfAccount}");
    }

}