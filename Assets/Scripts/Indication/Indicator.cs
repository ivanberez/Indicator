using UnityEngine;

public class Indicator : MonoBehaviour
{
    [SerializeField] private IndicationElement[] indications;
    [SerializeField] private bool _isSmotherImage;
    [SerializeField] private bool _isSmotherText;

    private IDataIndication _dataIndication;

    private void OnDisable()
    {
        _dataIndication.Changed -= Refresh;
    }

    public void Initialization(IDataIndication dataIndication)
    {
        _dataIndication = dataIndication;
        _dataIndication.Changed += Refresh;
        Refresh();
    }

    private void Refresh()
    {
        foreach (var indication in indications)
            indication.Refresh(_dataIndication, GetIsSmoother(indication));
    }

    private bool GetIsSmoother(IndicationElement indication)
    {
        switch (indication)
        {
            case IndicationText: return _isSmotherText;
            case IndicationBar: return _isSmotherImage;
            default: return false;
        }
    }
}