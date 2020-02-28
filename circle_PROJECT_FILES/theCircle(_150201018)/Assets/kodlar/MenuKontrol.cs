using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour {
    // create "go to game" method
	public void oyunagit()
    {
        // load the game when user press te "Start" button
        SceneManager.LoadScene("1");

    }
    // create a method for exit the game
    public void cık()
    {
        // when user prees the "Exit" just exit and close the game
        Application.Quit();
    }

}
