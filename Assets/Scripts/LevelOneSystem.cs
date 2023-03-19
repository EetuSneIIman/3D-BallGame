using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneSystem : MonoBehaviour
{

    
    public GameObject LevelApple;

    public GameObject ObjectiveText;
    public GameObject HolderApple;
    public GameObject TalkBobble;
    public GameObject InfoText;
    public GameObject InfoBadge;
    
    

    public static bool ObjectiveCombleted = false;

    
    public static bool AppleInInventory = false;
    
    public static bool ExitLevel = false;
    public static bool RobotTextBool = false;
    

    public void Update()
    {
       

        if (RobotTextBool)
        {
            LevelApple.SetActive(false);
            HolderApple.SetActive(false);
            ObjectiveCombleted = true;
        }
    
        if (ObjectiveCombleted)
        {
            TalkBobble.SetActive(false);
            ObjectiveText.SetActive(false);
            InfoText.SetActive(true);
            InfoBadge.SetActive(true);
            ExitLevel = true;
        }
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            LevelApple.SetActive(false);
            HolderApple.SetActive(true);
            AppleInInventory = true;
        }
            

    }
}
