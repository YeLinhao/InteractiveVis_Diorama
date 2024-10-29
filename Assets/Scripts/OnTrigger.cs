using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if (other.tag == "Pig")
        {
            //Pigs Dead
            GameManager.instance.Pigs.Remove(other.gameObject);
            Destroy(other.gameObject);
            //boomer+1
            UIManager.instance.boomerSpawner.BoomNumberTemp++;

            //Check if winning
            if (GameManager.instance.Pigs.Count == 0)
            {
                UIManager.instance.winningPanel.SetActive(true);
            }
        }

    }
}

