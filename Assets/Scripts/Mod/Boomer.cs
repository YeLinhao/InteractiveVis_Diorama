using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Rendering;

public class Boomer : MonoBehaviour
{

    public float countdown = 3f;
    public float radius = 5f;
    public float force = 700f;

    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && !hasExploded)
        {
            Debug.Log("explode!");
            Explode();
            hasExploded = true;
        }


    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position,radius);

        foreach(Collider nearObject in colliders){
            Rigidbody rb = nearObject.GetComponent<Rigidbody>();
            if(rb != null)
            {
                rb.AddExplosionForce(force,transform.position,radius);
            }
        }

        Destroy(gameObject);

    }



}
