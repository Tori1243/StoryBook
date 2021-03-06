﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class WaitSec : MonoBehaviour
{
    public UnityEvent TimeUpEvent;

    public float time;
    
    public void StartTimer()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(time);
        TimeUpEvent.Invoke();
    }
}