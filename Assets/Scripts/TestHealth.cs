using System;
using UnityEngine;

public class TestHealth : MonoBehaviour, IDataIndication
{
    [SerializeField, Min(0)] private float _curent;
    [SerializeField, Min(0)] private float _max;        
    
    public event Action Changed;

    public float Curent => _curent;
    public float Max => _max;    

    public void TakeDamage(float damage) 
    {
        _curent -= Mathf.Clamp(damage, 0, _curent); 
        Changed?.Invoke(); 
    }

    public void TakeAidKit(float count)
    {
        _curent += Mathf.Clamp(count, 0, _max - _curent);
        Changed?.Invoke();
    }
}
