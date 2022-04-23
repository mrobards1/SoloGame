using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public SpriteRenderer spriteRender;
    public Image imageColor;
   
    

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        imageColor = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        changeImageColor();
    }

    public void ChangeColor()
    {
        if (Singleton.Instance.color == 1)
        {
            spriteRender.color = new Color(1, 1, 1, 1); //white
        }
        if (Singleton.Instance.color == 2)
        {
            spriteRender.color = new Color(1, 0, 0, 1); //red
        }
        if (Singleton.Instance.color == 3)
        {
            spriteRender.color = new Color(0, 1, 0, 1); //green
        }
        if (Singleton.Instance.color == 4)
        {
            spriteRender.color = new Color(0, 0, 1, 1); //blue
        }
        if (Singleton.Instance.color == 5)
        {
            spriteRender.color = new Color(1, 0.92f, 0.016f, 1); //yellow
        }
        if (Singleton.Instance.color == 6)
        {
            spriteRender.color = new Color(1, 0, 1, 1); //magenta
        }

        if (Singleton.Instance.color == 7)
        {
            spriteRender.color = new Color(0.5f, 0.5f, 0.5f, 1); //gray
        }

    }

    public void changeImageColor()
    {
        if (Singleton.Instance.color == 1)
        {
            imageColor.color = new Color(1, 1, 1, 1); //white
        }
        if (Singleton.Instance.color == 2)
        {
            imageColor.color = new Color(1, 0, 0, 1); //red
        }
        if (Singleton.Instance.color == 3)
        {
            imageColor.color = new Color(0, 1, 0, 1); //green
        }
        if (Singleton.Instance.color == 4)
        {
            imageColor.color = new Color(0, 0, 1, 1); //blue
        }
        if (Singleton.Instance.color == 5)
        {
            imageColor.color = new Color(1, 0.92f, 0.016f, 1); //yellow
        }
        if (Singleton.Instance.color == 6)
        {
            imageColor.color = new Color(1, 0, 1, 1); //magenta
        }

        if (Singleton.Instance.color == 7)
        {
            imageColor.color = new Color(0.5f, 0.5f, 0.5f, 1); //gray
        }
    }
}
