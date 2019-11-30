using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DestroyObject : MonoBehaviour
{
    public UnityEvent ClickEvent;

    private void OnMouseDown()
    {
        ClickEvent.Invoke();
        Destroy(gameObject);
    }

}