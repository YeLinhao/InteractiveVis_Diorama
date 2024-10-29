using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    public BoomerSpawner boomerSpawner;
    public TMP_Text boomerCount_TXT;
    public GameObject winningPanel;



    void FixedUpdate(){
        if (boomerCount_TXT != null)
        {
            boomerCount_TXT.text = boomerSpawner.BoomNumberTemp.ToString() + " / " + boomerSpawner.BoomNumberMax.ToString();
        }
        
    }


    public void LoadScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }

    public void Quit(){
        Debug.Log("Quit!");
        Application.Quit();
    }

}