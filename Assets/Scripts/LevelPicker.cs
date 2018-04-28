using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPicker : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClickLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void OnClickLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void OnClickLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LevelSelecter()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Pause()
    {
        
    }
}
