using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class fifo : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public TMP_Text uiText;
    public GameObject errorText;
    

    //[SerializeField] public fcfsInfo data;
    //[SerializeField] public ganndata chart;
    [SerializeField] public gameData data;
    
    void Start()
    {
	uiText.text = "FIFO Current Time: " + data.currentTime;
        errorText.SetActive(false);
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider Player)
    { 
	if(data.fifo){
        if (Player.gameObject.tag == "Player")
        {
            if (Player.gameObject.name == "player1" && data.check1)
            {
                data.check1 = false;
                data.check2 = true;

		data.currentTime = 2;
		data.waitTime = 0;

		//setRun.run = false;
		uiText.text = data.currentTime.ToString();
                
		
                SceneManager.LoadScene(2);
            }
            else if (Player.gameObject.name == "player2" && data.check2)
            {
                
                
		data.currentTime = 5;
		data.waitTime = 1;
                data.check2 = false;
                data.check3 = true;

		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
            }
            else if (Player.gameObject.name == "player3" && data.check3)
            {
                
             	data.currentTime = 8;
		data.waitTime = 2;   
                data.check3 = false;
                data.check4 = true;
		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
            }
            else if (Player.gameObject.name == "player4" && data.check4)
            {
                 
                 data.currentTime = 9;
		data.waitTime = 6;
                 data.check4 = false;
	        //data.check1 = true;
		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
                 //check2 = true;
            }
            else
            {
                errorText.SetActive(true);
                StartCoroutine("WaitFor5ec");
		//if(Player.gameObject.name == "player1"){
      		//	player1.GetComponent<moveBack>().enabled = true;
		//	player1.GetComponent<PlayerMovement>().enabled = false;
                 //}
            }

        }
        }else if(data.sjf){
                 if (Player.gameObject.tag == "Player")
        {
            if (Player.gameObject.name == "player1" && data.check1)
            {
                data.check1 = false;
                data.check2 = true;

		data.currentTime = 2;
		data.waitTime = 0;

		//setRun.run = false;
		uiText.text = data.currentTime.ToString();
                
		
                SceneManager.LoadScene(2);
            }
            else if (Player.gameObject.name == "player2" && data.check2)
            {
                
                
		data.currentTime = 5;
		data.waitTime = 1;
                data.check2 = false;
                data.check3 = true;
                
		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
            }
            else if (data.check3 && Player.gameObject.name == "player4")
            {
                
             	data.currentTime = 6;
		data.waitTime = 1;   
                data.check3 = false;
                data.check4 = true;
		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
            }
            else if (data.check4 && Player.gameObject.name == "player3" && Player.gameObject.name != "player4")
            {
                 
                 data.currentTime = 9;
		data.waitTime = 3;
                 data.check4 = false;

	        //data.check1 = true;
		//setRun.run = false;
                 uiText.text = data.currentTime.ToString();
		SceneManager.LoadScene(2);
                 //check2 = true;
            }
            else
            {
                errorText.SetActive(true);
                StartCoroutine("WaitFor5ec");
		//if(Player.gameObject.name == "player1"){
      		//	player1.GetComponent<moveBack>().enabled = true;
		//	player1.GetComponent<PlayerMovement>().enabled = false;
                 //}
            }

        }
        }
    }

    IEnumerator WaitFor5ec()
    {
       yield return new WaitForSeconds(5);

       errorText.SetActive(false);
    }
}
