namespace DesignPatternsSample.BuilderSample;

public class Room
{
    private string _name;
    private int numberOfBeds;
    private bool wifiFreeOfCharge;
    private bool balconyAvaliable;

    public Room(string name)
    {
        this._name = name;
    }

    public Room WithBalcony()
    {
        balconyAvaliable = true;
        return this;
    }

    public Room WithBed(int numberOfBeds)
    {
        this.numberOfBeds = numberOfBeds;
        return this;
    }

    public Room WithWifi()
    {
        wifiFreeOfCharge = true;
        return this;
    }
}