using System;
using UnityEngine;

public class TestHealth : MonoBehaviour, IDataIndication
{
    [SerializeField, Min(0)] private float _curent;
    [SerializeField, Min(0)] private float _max;    
    [SerializeField] private Indicator _indicator;

    [SerializeField, Min(0)] private float _testDamaged;
    [SerializeField, Min(0)] private float _testAidKit;

    public event Action Changed;

    public float Curent => _curent;
    public float Max => _max;    

    private void Awake()
    {
        _indicator.Initialization(this);
    }

    public void TakeDamage() 
    {
        _curent -= Mathf.Clamp(_testDamaged, 0, _curent); 
        Changed?.Invoke(); 
    }

    public void TakeAidKit()
    {
        _curent += Mathf.Clamp(_testAidKit, 0, _max - _curent);
        Changed?.Invoke();
    }
}
