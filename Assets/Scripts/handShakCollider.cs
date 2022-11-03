using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handShakCollider : MonoBehaviour
{
    [SerializeField] public Animator player;
    [SerializeField] public Animator manager;
    public GameObject errorText;
    void Start()
    {
        errorText.SetActive(false);
    }
    private void OnTriggerEnter(Collider Player){
	player.SetBool("isSalute",true);
        manager.SetBool("isSalute",true);
        errorText.SetActive(true);
        StartCoroutine("WaitFor5ec");
    }
    private void OnTriggerExit(Collider Player){
	player.SetBool("isSalute",false);
        manager.SetBool("isSalute",false);
    }
    IEnumerator WaitFor5ec()
    {
       yield return new WaitForSeconds(5);

       errorText.SetActive(false);
    }
}
