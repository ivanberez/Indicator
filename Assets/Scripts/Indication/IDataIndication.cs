using System;

public interface IDataIndication
{
    event Action Changed;

    float Curent { get; }
    float Max { get; }
}