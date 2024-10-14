using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Renderer ren;
    public int bouncingColor = 254;
    public GameObject floor;


    // Start is called before the first frame update
    void Start()
    {
       ren = GetComponent<Renderer>(); 
       if(ren != null)
       {
            ren.material.color = Color.red;
       }

       if(floor != null && floor.GetComponent<Renderer>() != null)
       {
            floor.GetComponent<Renderer>().material.color = Color.blue; 
       }
       else
            Debug.Log("missing object");
       
    }

    // Update is called once per frame
    void Update()
    {
        if(ren == null) return;

        if(Input.GetKeyDown(KeyCode.R))
        {
            ren.material.color = Color.red;
        }
        else if(Input.GetKeyDown(KeyCode.G))
        {
            ren.material.color = Color.green;
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            ren.material.color = Color.blue;
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            bouncingColor++;
            ren.material.color = new Color(bouncingColor,0,0);
        }

    }
}
