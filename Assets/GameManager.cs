using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public int EnemyNum;


    public List<GameObject> Pigs;
    private void Start()
    {
        var pigs = GameObject.FindGameObjectsWithTag("Pig");
        Pigs.AddRange(pigs);
    }

}
