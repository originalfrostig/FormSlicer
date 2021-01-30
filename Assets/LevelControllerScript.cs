using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = System.Object;

public class LevelControllerScript : MonoBehaviour
{
    private GameControllerScript _gameControllerScript;
    private int nextLevel;
    private float waitTime = 5;

    private void Start()
    {
        
        _gameControllerScript =  FindObjectOfType<GameControllerScript>();
        nextLevel = _gameControllerScript.getLevelScene()+1;
    }


    public void winGame()
    {
        
        if (PlayerPrefs.GetInt("Level",0) < nextLevel)
        {
            PlayerPrefs.SetInt("Level",nextLevel);
        } 
        
        StartCoroutine(wait());
        
        
        
        
        
        
    }
    
    IEnumerator wait()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(waitTime);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        _gameControllerScript.changeScene();
    }
}
