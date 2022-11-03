using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outsidePlayerMovement : MonoBehaviour
{
    
    public Animator player;
    //public CharacterController controller;
    public float speed = 0.1f;
    public float rotationSpeed = 100f; 
    float xRotation = 0f;
    Vector3 Vec;
    // Start is called before the first frame update
    void Start()
    {
        //anim  = GetComponentInChildren<Animator>();
    }
  
  
    // Update is called once per frame  
    void Update()  
    {   
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
          
        if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -5);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 5);  
        }  
  
    }  
}
