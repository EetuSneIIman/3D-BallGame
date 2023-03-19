using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneRobot : MonoBehaviour
{
    public GameObject RobotText;

    public Animator animator;

   

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if (LevelOneSystem.AppleInInventory)
            {
                RobotText.SetActive(true);
                animator.SetBool("Spin", true);
                LevelOneSystem.RobotTextBool = true;
                
            }
        }
        
        
        
    }
   

}
