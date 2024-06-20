using UnityEngine;

public class VisualizationHub : MonoBehaviour
{
    [SerializeField] private TestHealth _health1, _health2;
    [SerializeField] private Indicator _indicator1, _indicator2;

    private void Awake()
    {
        if (_health1 && _indicator1)
            _indicator1.Initialization(_health1);

        if( _health2 && _indicator2)
            _indicator2.Initialization(_health2);
    }
}
