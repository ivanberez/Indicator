using System;
using UnityEngine;

public class DataIndicator : MonoBehaviour, IDataIndication
{
    [SerializeField, Min(0)] private float _curent;
    [SerializeField, Min(0)] private float _max;    
    [SerializeField] private Indicator _indicator;

    [SerializeField] private float _testDamaged;
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
        _curent -= _testDamaged; 

        if( _curent < 0 ) 
            _curent = 0;

        Changed?.Invoke(); 
    }

    public void TakeAidKit()
    {
        _curent += _testAidKit;

        if(_curent > _max ) 
            _curent = _max; 

        Changed?.Invoke();
    }
}
