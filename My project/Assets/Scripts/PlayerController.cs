using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public float speed = 45.0f;
   public float turnSpeed ;
   
   public float horizontalInput ;
   public float verticalInput;
   
   public float forwardInput;
   public string inputID;

    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    private void Update()
    {// Input update
        if (name == "Car")
        {
            horizontalInput = Input.GetAxis("Horizontal1");
            verticalInput = Input.GetAxis("Vertical1");
        }
        else
        {
            horizontalInput = Input.GetAxis("Horizontal2");
            verticalInput = Input.GetAxis("Vertical2");
        }



        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        //we turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);


        

    }
  
   
}
