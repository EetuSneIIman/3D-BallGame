using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneTent : MonoBehaviour
{
    public GameObject NextLevel;
    public GameObject exitText;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            exitText.SetActive(false);
            NextLevel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }

    }
}
