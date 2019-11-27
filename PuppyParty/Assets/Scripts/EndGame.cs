using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }
}