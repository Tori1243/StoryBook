using UnityEngine;
using UnityEngine.Events;


public class OnMouseEvent : MonoBehaviour
{
   public UnityEvent OnMouseDownEvent;
   
   private void OnMouseDown()
    {
        OnMouseDownEvent.Invoke();
    }
}
