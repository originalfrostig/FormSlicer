using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneControllerScript : MonoBehaviour
{
    private GameControllerScript _gameControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
       _gameControllerScript =  Object.FindObjectOfType<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            _gameControllerScript.changeScene();
        }
    }
}
