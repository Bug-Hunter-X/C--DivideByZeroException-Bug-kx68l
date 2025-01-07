public class MyClass {
    private int _value;

    public int Value {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod() {
        if (Value == 0) {
            //Some code here that throws an exception
            throw new Exception("Value cannot be zero");
        }
        //More code here
        int result = 10 / Value; // Potential DivideByZeroException 
    }
}