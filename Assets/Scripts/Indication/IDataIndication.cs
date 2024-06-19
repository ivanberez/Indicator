using System;

public interface IDataIndication
{    
    float Curent { get; }
    float Max { get; }
    event Action Changed;
}