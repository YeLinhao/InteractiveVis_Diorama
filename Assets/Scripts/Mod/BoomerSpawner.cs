using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoomerSpawner : MonoBehaviour
{
    public GameObject BoomerPrefab;
    public int BoomNumberTemp;
    public int BoomNumberMax;
    public float spawnHeight = 5f;

    void Start(){
        BoomNumberTemp = BoomNumberMax;
    }

    // Start is called before the first frame update
    void OnMouseDown()
    {
        // send raycast from camera to mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Check if raycast hit the plane
        if (Physics.Raycast(ray, out hit))
        {
            // Then get the exact position of hit point
            Vector3 clickPosition = hit.point;

            // Spawn Position is just above the hit position, and the height can be modified.
            Vector3 spawnPosition = new Vector3(clickPosition.x, clickPosition.y + spawnHeight, clickPosition.z);

            //Bomb Spawn
            if(BoomNumberTemp > 0)
            {
                Instantiate(BoomerPrefab, spawnPosition, Quaternion.identity);
                BoomNumberTemp--;
            } 
        }
    }



}
