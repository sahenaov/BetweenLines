using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Deadzone : MonoBehaviour
{
    public static Action OnPlayerFall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(!(OnPlayerFall== null))
            {
                OnPlayerFall();
            }
        }

    }

 
}
