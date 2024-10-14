using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class OnCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision other){
        Debug.Log("hit!");
    }

    
}
