using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerSelute : MonoBehaviour
{
    [SerializeField] public Animator anim;
    

    private void OnTriggerEnter(Collider Player){
	anim.SetBool("isSalute",true);
    }
    
    private void OnTriggerExit(Collider Player){
	anim.SetBool("isSalute",false);
    }
}
