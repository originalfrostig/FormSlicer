using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionScript : MonoBehaviour
{
    private int lastLevel;

    public List<Button> levelButtons;
    
    // Start is called before the first frame update
    void Start()
    {
       lastLevel = PlayerPrefs.GetInt("Level", 0);
       Debug.Log(lastLevel);

       foreach (Button levelButton in levelButtons)
       {
           levelButton.interactable = false;
       }
       
       for (int i = 0; i < levelButtons.Count; i++)
       {
           if (lastLevel+1 < i)
           {
               break;
           }

           levelButtons[i].interactable = true;
       }

    }

    
    
}
