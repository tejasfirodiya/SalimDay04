//Console.WriteLine("============================================================");
//there is a two types of relationship :-
//    1. Is a relationship
//        - it is inheritence
//    eg. student IS-A sub class of College

//    2. has a relationship
//        - it is aggregation(independent), composition(depend)
//    eg. Student has-A property Address

//    Composition :-
//            - one class object is depend on another class object
//    library has book

//    Aggregation :-
//            -one class object is not depend on another class object.ReferenceEquals
//            -if there is dependancy then also its ok.
//            -jar object asel tari ok kiwwa nasel object tari ok.


//Console.WriteLine("============================================================");
Address add1 = new Address("Nagar","Ahmednagar");
Student s1 = new Student("Tejas",add1);
Student s2 = new Student("shubham",add1);
Address add2 = new Address("Pravara", "Pune");
Student s3 = new Student("abc",add2);

s1.display();
s2.display();
s3.display();

class Address
{
    public string city;
    public string dist;

    public Address(string city, string dist)
    {
        this.city = city;
        this.dist = dist;
    }
}

class Student
{
    string Name;
    public Address address;
    public Student(string name,Address add)
    {
        this.Name = name;
        this.address = add;
    }

    public void display()
    {
        Console.WriteLine($"{Name}, {address.city}, {address.dist}");
    }
}
//Console.WriteLine("============================================================");
