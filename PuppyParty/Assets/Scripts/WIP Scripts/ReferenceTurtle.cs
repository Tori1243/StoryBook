using UnityEngine;

public class ReferenceTurtle : MonoBehaviour
{
    public SelectRandomObj SRO;
    public GameObject placeOfTurtle;

    public void displayTurtle()
    {
        Instantiate(SRO.SelectedObject,placeOfTurtle.transform.position,Quaternion.identity);
    }
}
