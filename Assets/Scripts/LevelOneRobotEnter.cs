using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneRobotEnter : MonoBehaviour
{

    public GameObject ObjectiveText;
    public GameObject TalkToRobotText;
    public GameObject AppleCollider;
    public GameObject RobotTextApple;

    public void Start()
    {
        AppleCollider.SetActive(false);
        TalkToRobotText.SetActive(true);
    }

  

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            AppleCollider.SetActive(true);
            TalkToRobotText.SetActive(false);
            ObjectiveText.SetActive(true);
            RobotTextApple.SetActive(true);
        
            
        }

    }
}
