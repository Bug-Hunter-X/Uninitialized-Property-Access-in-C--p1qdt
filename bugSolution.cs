public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 10; // Or any other initial value
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now MyProperty will have the initialized value
    }
}