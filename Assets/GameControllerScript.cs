using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    public int currentScene = 0;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
    }

    public void changeScene()
    {
        currentScene++;
        SceneManager.LoadSceneAsync(currentScene);
        
    }

    public void loadScene(int sceneNumber)
    {
        currentScene = sceneNumber;
        SceneManager.LoadSceneAsync(currentScene);
    }
}
