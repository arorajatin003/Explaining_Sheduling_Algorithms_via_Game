using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //[SerializeField] public fcfsInfo data;
    //public gannChart chart;
    [SerializeField] public gameData data;

    public void PlayGame()
    {
        data.check1 = true;
	data.check2 = false;
	data.check3 = false;
	data.check4 = false;
	data.currentTime = 0;
	data.waitTime = 0;
        Debug.Log("change");
        SceneManager.LoadScene(1);
    } 
    public void quitGame(){
	Application.Quit();
	Debug.Log("Quit");
    }
    public void selectFIFO(){
         data.fifo = true;
         data.sjf = false;
    }
    public void selectSJF(){
         data.fifo =false;
         data.sjf = true;
    }
}
