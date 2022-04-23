using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



[System.Serializable]
public class UI_Controller : MonoBehaviour
{


    // Get references to your UI objects
    private InputField CharacterNameInput;
   
    private Dropdown colorSelect;
    
    private Dropdown difficulty;
   

    void Start()
    {
        UIReferences();
    }

    private void UIReferences()
    {

        CharacterNameInput = GameObject.Find("CharacterNameInput").GetComponent<InputField>();
        CharacterNameInput.onEndEdit.AddListener(CharacterName);
        
        
        
        colorSelect = GameObject.Find("Color_Select").GetComponent<Dropdown>();
        colorSelect.onValueChanged.AddListener(CallBack_Color);

        
        difficulty = GameObject.Find("Difficulty_Select").GetComponent<Dropdown>();
        difficulty.onValueChanged.AddListener(CallBack_Difficulty);

       

    }

    

   


    public void CharacterName(string characterName)
    {
        Singleton.Instance.characterName = characterName;
       
    }


    public void CallBack_Difficulty(int difficulty)
    {
        
        
        Singleton.Instance.difficulty = difficulty;
       

    }

    public void CallBack_Color(int colorSelect)
    {
        
        
        Singleton.Instance.color = colorSelect;
    }

    

    

    

    



}