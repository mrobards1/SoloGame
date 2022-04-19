using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerPosition;

    public Vector3 zoomOut;
    
    private void FixedUpdate()
    {
        transform.position = playerPosition.position + zoomOut;
    }
}
