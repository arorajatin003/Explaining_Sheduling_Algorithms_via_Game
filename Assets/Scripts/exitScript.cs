using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitScript : MonoBehaviour
{
    [SerializeField] public gameData data;
    private void OnTriggerEnter(Collider Player)
    {
	if(data.check1 || data.check2 || data.check3 || data.check4)
        		SceneManager.LoadScene(1);
	else
        		SceneManager.LoadScene(3);
    }
}