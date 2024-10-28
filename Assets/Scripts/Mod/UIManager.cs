using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{


    public BoomerSpawner boomerSpawner;
    public TMP_Text boomerCount_TXT;

    void FixedUpdate(){
        boomerCount_TXT.text = boomerSpawner.BoomNumberTemp.ToString() + " / " + boomerSpawner.BoomNumberMax.ToString();
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