using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public TMP_Text waitTime;
    public TMP_Text totalTime;
    
    [SerializeField]
    public gameData data;
    
    void Start()
    {
        float wt =  (float)data.waitTime/4;
        totalTime.text = "Total Time: " + data.currentTime;
	waitTime.text = "Avg Waiting Time: " + wt;
        data.currentTime = 0;
        data.waitTime = 0;

    }
     void Update(){
         if(Input.GetButtonDown("Cancel")){
	   Application.Quit();
	   Debug.Log("Quit");
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Start");
    } 
    public void quitGame(){
	
	Application.Quit();
	Debug.Log("Quit");
    } 
    
}
