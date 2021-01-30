using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = System.Object;

public class LevelControllerScript : MonoBehaviour
{
    private GameControllerScript _gameControllerScript;
    private int currentLevel;
    public float waitTime;

    private void Start()
    {
        
        _gameControllerScript =  FindObjectOfType<GameControllerScript>();
        currentLevel = _gameControllerScript.getLevelScene();
    }


    public void winGame()
    {
        
        StartCoroutine(wait());
        
        if (PlayerPrefs.GetInt("Level",0) < currentLevel)
        {
            PlayerPrefs.SetInt("Level",currentLevel);
        } 
        
        
        
        
    }
    
    IEnumerator wait()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        _gameControllerScript.changeScene();
    }
}
