using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour
{

    public void loadPlayerCreation()
    {
        SceneManager.LoadScene("Player_Create_Scene");
    }

    public void loadLevelOne()
    {
        SceneManager.LoadScene("Level_One_Scene");
        
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu_Scene");
    }

    public void loadAbout()
    {
        SceneManager.LoadScene("About_Scene");
    }

    public void loadSettings()
    {
        SceneManager.LoadScene("Settings_Scene");
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level_One_Scene")
        {
            FindObjectOfType<AudioManager>().Pause("Theme");
            
        }

        
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
