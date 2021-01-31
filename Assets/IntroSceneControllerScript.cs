using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class IntroSceneControllerScript : MonoBehaviour
{
    private GameControllerScript _gameControllerScript;
    public AudioClip _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        
       _gameControllerScript =  FindObjectOfType<GameControllerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            FindObjectOfType<MusicController>().playSound(_audioSource);
            _gameControllerScript.changeScene();
        }
    }
}
