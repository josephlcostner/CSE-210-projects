public class Fraction
{
   private int _topNumber;
   private int _bottomNumber; 
   private int _function;
   
   
    public Fraction(int topNumber, int bottomNumber, int function)
        {
            _topNumber = topNumber;
            _bottomNumber = bottomNumber;
            _function = topNumber / bottomNumber;
            _function = function;
        }
    public int topNumber
    {
        get {return _topNumber; }
    }

    public int bottomNumber
    {
        get {return _bottomNumber; }
    }

    public int function
    {
        get {return _function; }
    }
    
    
   
}
