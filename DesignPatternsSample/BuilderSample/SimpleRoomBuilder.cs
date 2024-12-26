namespace DesignPatternsSample.BuilderSample;

public class SimpleRoomBuilder : IRoomBuilder
{
    public Room Build()
    {
        return new Room("Simple").WithBed(1);
    }
}