using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Animator anim;
    public float speed = 0.1f;
    private Vector3 moveDirection;
    private Vector3 velocity;
    
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;
    
    // Start is called before the first frame update
    void Start()
    {
        anim  = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
	if(move * speed != Vector3.zero){
	    anim.SetBool("isWaking", true);
	}else{
	   anim.SetBool("isWaking", false);
	}


        
        controller.Move(move * speed * Time.deltaTime);

    }
}
