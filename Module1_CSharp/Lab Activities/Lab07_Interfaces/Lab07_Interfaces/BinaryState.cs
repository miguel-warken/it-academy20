public enum BinaryState { ON, OFF };

interface IBinaryState
{
    void turnOn();
    void turnOff();
    BinaryState State { get; }
}