using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player0;
    public GameObject dollyCamera;
    public GameObject movingPlayer;
    public GameObject movingCamera;
    public GameObject uiText;
    
  
    // Start is called before the first frame update
    void Start()
    {

	player0.SetActive(false);
        dollyCamera.SetActive(true);
        movingCamera.SetActive(false);
        movingPlayer.GetComponent<basicMovement>().enabled = false;
        //player1.GetComponent<PlayerMovement>().enabled = false;
        //player2.GetComponent<PlayerMovement>().enabled = false;
        //player3.GetComponent<PlayerMovement>().enabled = false;
        //player4.GetComponent<PlayerMovement>().enabled = false;
        player1.GetComponent<outsidePlayerMovement>().enabled = false;
        player2.GetComponent<outsidePlayerMovement>().enabled = false;
        player3.GetComponent<outsidePlayerMovement>().enabled = false;
        player4.GetComponent<outsidePlayerMovement>().enabled = false;
        //uiText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {    
         
        if (Input.GetButtonDown("0Key"))
        {
            player0.SetActive(true);
            movingCamera.SetActive(false);
            movingPlayer.GetComponent<basicMovement>().enabled =false;
            //player1.GetComponent<PlayerMovement>().enabled = false;
            //player2.GetComponent<PlayerMovement>().enabled = false;
            //player3.GetComponent<PlayerMovement>().enabled = false;
            //player4.GetComponent<PlayerMovement>().enabled = false;

            player1.GetComponent<outsidePlayerMovement>().enabled = false;
            player2.GetComponent<outsidePlayerMovement>().enabled = false;
            player3.GetComponent<outsidePlayerMovement>().enabled = false;
            player4.GetComponent<outsidePlayerMovement>().enabled = false;
            //uiText.SetActive(true);

        }
        if (Input.GetButtonDown("1Key"))
        {
            movingCamera.SetActive(false);
            movingPlayer.GetComponent<basicMovement>().enabled =false;
            player1.GetComponent<PlayerMovement>().enabled = true;
            player2.GetComponent<PlayerMovement>().enabled = false;
            player3.GetComponent<PlayerMovement>().enabled = false;
            player4.GetComponent<PlayerMovement>().enabled = false;

            player1.GetComponent<outsidePlayerMovement>().enabled = true;
            player2.GetComponent<outsidePlayerMovement>().enabled = false;
            player3.GetComponent<outsidePlayerMovement>().enabled = false;
            player4.GetComponent<outsidePlayerMovement>().enabled = false;
            //uiText.SetActive(false);

        }
        if (Input.GetButtonDown("2Key"))
        {
            movingCamera.SetActive(false);
            movingPlayer.GetComponent<basicMovement>().enabled = false;
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<PlayerMovement>().enabled = true;
            player3.GetComponent<PlayerMovement>().enabled = false;
            player4.GetComponent<PlayerMovement>().enabled = false;

            player1.GetComponent<outsidePlayerMovement>().enabled = false;
            player2.GetComponent<outsidePlayerMovement>().enabled = true;
            player3.GetComponent<outsidePlayerMovement>().enabled = false;
            player4.GetComponent<outsidePlayerMovement>().enabled = false;
            //uiText.SetActive(false);
        }
        if (Input.GetButtonDown("3Key"))
        {
            movingCamera.SetActive(false);
            movingPlayer.GetComponent<basicMovement>().enabled =false;
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<PlayerMovement>().enabled = false;
            player3.GetComponent<PlayerMovement>().enabled = true;
            player4.GetComponent<PlayerMovement>().enabled = false;

            player1.GetComponent<outsidePlayerMovement>().enabled = false;
            player2.GetComponent<outsidePlayerMovement>().enabled = false;
            player3.GetComponent<outsidePlayerMovement>().enabled = true;
            player4.GetComponent<outsidePlayerMovement>().enabled = false;
            //uiText.SetActive(false);
        }
        if (Input.GetButtonDown("4Key"))
        {
            movingCamera.SetActive(false);
            movingPlayer.GetComponent<basicMovement>().enabled = false;
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<PlayerMovement>().enabled = false;
            player3.GetComponent<PlayerMovement>().enabled = false;
            player4.GetComponent<PlayerMovement>().enabled = true;

            player1.GetComponent<outsidePlayerMovement>().enabled = false;
            player2.GetComponent<outsidePlayerMovement>().enabled = false;
            player3.GetComponent<outsidePlayerMovement>().enabled = false;
            player4.GetComponent<outsidePlayerMovement>().enabled = true;
            //uiText.SetActive(false);
        }
        if (Input.GetButtonDown("5Key"))
        {
            movingCamera.SetActive(true);
            movingPlayer.GetComponent<basicMovement>().enabled = true;
            player0.SetActive(false);
            player1.GetComponent<PlayerMovement>().enabled = false;
            player2.GetComponent<PlayerMovement>().enabled = false;
            player3.GetComponent<PlayerMovement>().enabled = false;
            player4.GetComponent<PlayerMovement>().enabled = false;

            player1.GetComponent<outsidePlayerMovement>().enabled = false;
            player2.GetComponent<outsidePlayerMovement>().enabled = false;
            player3.GetComponent<outsidePlayerMovement>().enabled = false;
            player4.GetComponent<outsidePlayerMovement>().enabled = false;
            //uiText.SetActive(false);
        }

        if(Input.GetButtonDown("Cancel")){
	   Application.Quit();
	   Debug.Log("Quit");
        }
        if(Input.GetButtonDown("continue")){
	  player0.SetActive(true);
          dollyCamera.SetActive(false);
        }
    }
}
