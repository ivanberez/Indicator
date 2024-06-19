using System.Collections;
using UnityEngine;

public abstract class IndicationElement : MonoBehaviour
{
    private Coroutine _coroutine;

    public void Refresh(IDataIndication dataIndication, bool isSmoother)
    {
        if (isSmoother)
            SmoothedDisplay(dataIndication);
        else
            InstantDisplay(dataIndication);
    }

    protected abstract void InstantDisplay(IDataIndication dataIndication);
    protected abstract IEnumerator SmoothedDisplayRoutine(IDataIndication dataIndication);
    
    private void SmoothedDisplay(IDataIndication dataIndication)
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(SmoothedDisplayRoutine(dataIndication));
    }
}