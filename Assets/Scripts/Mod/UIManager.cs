using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void LoadScene(int SceneNum)
    {
        SceneManager.LoadScene(SceneNum);
    }

    public void Quit(){
        Debug.Log("Quit!");
        Application.Quit();
       
    }

}