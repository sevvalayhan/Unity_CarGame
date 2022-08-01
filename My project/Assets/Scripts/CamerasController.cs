using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerasController : MonoBehaviour
{
    public Camera MainCamera;
    public Camera TPSCamera;
    public bool isFPS;

     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            isFPS = !isFPS;
            CheckCamera();
        }
        
    }
    void CheckCamera()
    {
        if (isFPS)
        {
            MainCamera.enabled = true;
            TPSCamera.enabled = false;
        }
        else
        {
            MainCamera.enabled=false;
            TPSCamera.enabled = true;
        }
    }
}
