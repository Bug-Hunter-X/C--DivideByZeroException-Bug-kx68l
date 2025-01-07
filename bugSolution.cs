public class MyClass {
    private int _value;

    public int Value {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod() {
        if (Value == 0) {
            // Handle the case where Value is zero.
            Console.WriteLine("Value cannot be zero. Returning a default value.");
            return; //Or throw a more specific exception with better handling
        }
        int result = 10 / Value; 
        Console.WriteLine("Result: " + result);
    }
} 