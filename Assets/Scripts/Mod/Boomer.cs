using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

public class Boomer : MonoBehaviour
{

    public float countdown;
    public float radius;
    public float force;
    public bool ifHardMode;
    public void SetArgumentForDiffMode()
    {
        ifHardMode = !ifHardMode;
        if (!ifHardMode)
        {
            radius = 10f;
            force = 1200f;
        }

        if (ifHardMode)
        {
            radius = 5f;
            force = 700f;
        }
    }

    public void SetHardModeToDefault(bool Default)
    {
        ifHardMode = default;
        radius = 10f;
        force = 1200f;
    }
    public GameObject BoomEffectPrefab;

    bool hasExploded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
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
        var boomEffectClone = Instantiate(BoomEffectPrefab,this.transform.position,Quaternion.identity);
        Destroy(boomEffectClone,5);
        Destroy(gameObject);

    }





}
