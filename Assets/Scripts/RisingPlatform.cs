using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RisingPlatform : MonoBehaviour
{

    private float speed;
    public int startingPoint;
    public Transform[] points;

    
    

    public int i;


    

    void Start()
    {
        
        transform.position = points[startingPoint].position;
        setSpeed();
        
    }

    

    
    void Update()
    {
        if (Vector2.Distance(transform.position, points[i].position) < 0.01f)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }

        }

        transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        
        
    }

    public void setSpeed()
    {
        if(Singleton.Instance.difficulty == 1)
        {
            speed = 1.5f;
        }
        if (Singleton.Instance.difficulty == 2)
        {
            speed = 1.8f;
        }
        if (Singleton.Instance.difficulty == 3)
        {
            speed = 2;
        }
    }

    
}
