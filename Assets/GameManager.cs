using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

    private void Awake()
    {
        //Set screen size for Standalone
#if UNITY_STANDALONE
        Screen.SetResolution(600, 800, false);
        Screen.fullScreen = false;
#endif
    }

    public bool isGameEnd = false;
    
	public void Gameover()
    {
        if(isGameEnd == false)
        {
            isGameEnd = true;
            Debug.Log("Öldün");
            Restart();
        }
        
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
