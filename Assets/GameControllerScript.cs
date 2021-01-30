using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour
{

    public int currentScene = 0;

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
