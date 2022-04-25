using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{

    public static Singleton Instance { get; private set; }

    public string characterName;
    public int color;
    public int difficulty;
    public bool isFilledOut;
    public float volume;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

   
    
}
