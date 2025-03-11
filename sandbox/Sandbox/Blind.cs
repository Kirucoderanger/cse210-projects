public class Blind
{
  public double _width;
  public double _height;
  public string _color;
  
    // additional function can be created in side a class
    public double GetArea()
    {
        return _width * _height;
    }
}


public class House
{
    public string _owner;
    public Blind _kitchen;
    public Blind _livingRoom;
}

public class HouseList
{
    public string _owner;
    public List<Blind> _blinds = new List<Blind>();
    internal object _kitchen;
}