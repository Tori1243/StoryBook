using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisonEvent : MonoBehaviour
{

	public UnityEvent CollisionEnterEvent;

	private void OnCollisionEnter(Collision other)
	{
		CollisionEnterEvent.Invoke();
	}

}
