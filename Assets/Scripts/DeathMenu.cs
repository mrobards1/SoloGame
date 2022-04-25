using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DeathMenu : MonoBehaviour
{
    public RisingPlatform risingPlatform;

   

    // Update is called once per frame
    void Update()
    {
        
    }


    public void toggleDeathMenu()
    {
        gameObject.SetActive(true);
        
        FindObjectOfType<AudioManager>().Play("DeathMusic");
       

    }

    public void startOnLevel()
    {
        gameObject.SetActive(false);
        FindObjectOfType<AudioManager>().Pause("DeathMusic");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Main_Menu_Scene");
        FindObjectOfType<AudioManager>().Pause("DeathMusic");
    }

}
