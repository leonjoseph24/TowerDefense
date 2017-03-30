using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour {

	public void PlayGame() //to load the game from the play button
    {
        SceneManager.LoadScene("Game");
    }


}
