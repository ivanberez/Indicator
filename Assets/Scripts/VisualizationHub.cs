using UnityEngine;

public class VisualizationHub : MonoBehaviour
{
    [SerializeField] private TestHealth _health;
    [SerializeField] private Indicator[] _indicators;

    private void Awake()
    {
        if(_health && _indicators != null)
        {
            foreach(var indicator in _indicators)
                indicator.Initialize(_health);
        }            
    }
}
