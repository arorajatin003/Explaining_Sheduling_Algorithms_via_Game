using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBack : MonoBehaviour
{
    public Transform target;
    public float speed = 1f;
    public CharacterController controller;
    //public GameObject playerBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
	
        transform.LookAt(target);
        controller.Move(move * speed * Time.deltaTime);
    }
}
