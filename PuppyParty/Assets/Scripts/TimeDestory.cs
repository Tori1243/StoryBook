using System.Collections;
using UnityEngine;

public class TimeDestory : MonoBehaviour
{
	public float objLastsTime = 3;
    
	IEnumerator Start()
	{
		yield return new WaitForSeconds(objLastsTime);
		Destroy(gameObject);
	}
}

