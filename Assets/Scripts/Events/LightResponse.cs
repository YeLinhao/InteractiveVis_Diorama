using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class LightResponse : MonoBehaviour
{
    public UnityEvent Event_Lighting;

    private void Start(){
        GameEvents.current.onLightTrigger += Lighting;
    }

    private void Lighting(){
        Event_Lighting.Invoke();
    }

    public void ChangeLight(){
        Light LightComp = this.GetComponent<Light>();
        LightComp.enabled = !LightComp.enabled;
    }


}
