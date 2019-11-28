using UnityEngine;

public class SnapToPoint : MonoBehaviour{

	public GameObject ObjectToSnap;

	public void OnSnap(){
		ObjectToSnap.transform.position = transform.position;
	}

	}