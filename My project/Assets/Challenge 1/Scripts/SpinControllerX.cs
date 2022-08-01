using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinControllerX : MonoBehaviour
{
    public Vector3 rotspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotspeed * Time.deltaTime);
    }
}
