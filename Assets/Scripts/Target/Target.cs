using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Target : MonoBehaviour, IPointerClickHandler
{

    public Action<Target> Callback;

    public void OnPointerClick(PointerEventData eventData)
    {
        Callback?.Invoke(this);
    }
}
