using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionMenu;
    public GameObject Mainmenu;
    public GameObject Levelmenu;
    public static bool GameIsPaused = false;
    

    public void Start()
    {
        Time.timeScale = 1f;
    }

    public void Update()
    {
        Time.timeScale = 1f;
    }

    public void LevelOne()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Loading Scene...");
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
        Debug.Log("Loading Scene...");
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PlayButton()
    {
        Mainmenu.SetActive(false);

        Levelmenu.SetActive(true);
        Debug.Log("Options Opening...");
    }


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Shutting Down...");
    }


    public void OptionsMenu()
    {
        Mainmenu.SetActive(false);

        OptionMenu.SetActive(true);
        Debug.Log("Options Opening...");
    }

    public void BackToMenu()
    {
        Mainmenu.SetActive(true);

        Levelmenu.SetActive(false);
        OptionMenu.SetActive(false);
        Debug.Log("Menu Opening...");
    }
}
