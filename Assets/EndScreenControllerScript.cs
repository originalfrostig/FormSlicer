using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreenControllerScript : MonoBehaviour
{

    public float endScreenTime;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(changeHauptmenu());
        
    }

    private IEnumerator changeHauptmenu( )
    {
        
            yield return new WaitForSeconds(endScreenTime);
            print("WaitAndPrint " + Time.time);
            FindObjectOfType<GameControllerScript>().loadScene(0);
        
    }
    
    
}
