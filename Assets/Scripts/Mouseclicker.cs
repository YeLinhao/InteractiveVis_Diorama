using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouseclicker : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        

        if (!audioSource.isPlaying)
        {
            Debug.Log("played!");
            audioSource.Play();
        }

    }

    void OnMouseOver(){

        Debug.Log("Mouse Over!");
    }
}
