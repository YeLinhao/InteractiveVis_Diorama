using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class LightController : MonoBehaviour
{

    public UnityEvent OnLightSwitch;
  

    void OnMouseDown(){
        GameEvents.current.LightTrigger();
    }
    


}
