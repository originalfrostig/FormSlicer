using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    
    public AudioClip _audioClip;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(onClick);
    }

    private void onClick()
    {
        if (FindObjectOfType<MusicController>() != null)
        {
            FindObjectOfType<MusicController>().playSound(_audioClip);  
        }
        
    }
}
