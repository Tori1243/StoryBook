using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceTurtle : MonoBehaviour
{
    public SelectRandom SR;
    public GameObject placeOfTurtle;

    public void displayFish()
    {
        Instantiate(SR.SelectedObject,placeOfTurtle.transform.position,Quaternion.identity);
    }
}