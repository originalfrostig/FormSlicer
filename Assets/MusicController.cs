using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sounds;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        music = GetComponent<AudioSource>();
        
        SceneManager.sceneLoaded += OnSceneLoaded;
 
        
        music.Play();
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        if (FindObjectOfType<GameControllerScript>().lastScene())
        {
            music.Stop();
        }
        
    }

    public void playSound(AudioClip audioClip)
    {
        sounds.Stop();
        sounds.clip = audioClip;
        sounds.Play();
    }

}
