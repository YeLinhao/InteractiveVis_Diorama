using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;


    private void Awake(){
        current = this; // normal claim of singleton 
    }

    public event Action onLightTrigger;
    public void LightTrigger()
    {
        if(onLightTrigger != null)
        {
            onLightTrigger();
        }
    }





}
