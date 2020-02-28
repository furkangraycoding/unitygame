using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OyunYoneticisi : MonoBehaviour
{
    // create a rotating circle "donencember" and main circle "anacember"
    GameObject donencember;
    GameObject anacember;
    // create the some animation and assign the true scenerio
    public Animator animator;
    // create the text for show the level number
    public Text donencemberlevel;
    public Text bir;
    // create the control statement
    bool kontrol = true;
    // create the integer variable for the answer of "how many smallcircle will be ?"
    public int kaccemberolsun;
    void Start()
    {
        // assign the tags to the objects
        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
        // rotating circle with level number on it assigned to the scene name
        // we get the easy way for change the scene"level" with that
        donencemberlevel.text = SceneManager.GetActiveScene().name;

        // assigned howmanycirclewillbe to texted that named "bir"
        bir.text = kaccemberolsun + " ";


    }
    // create a method for showing to the small circle's numbers, rest of its
    public void kucuktextgosterme()
    {
        // decreased it and print again
        kaccemberolsun--;
        bir.text = kaccemberolsun + " ";

        // create a if statement for sliding to the new level"scene"
        if (kaccemberolsun == 0)
        {
            // when we have no smallcircle go to next level
            StartCoroutine(yenilevel());
        }

    }
    IEnumerator yenilevel()

    {
        // stop the rotating circle and maincircle when you finish the level
        donencember.GetComponent<Dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        // create a delay for showing the animation
        yield return new WaitForSeconds(0.8f);
        if (kontrol)
        {
            // show the yenilevel"newlevel" animation
            animator.SetTrigger("yenilevel");
            yield return new WaitForSeconds(1.4f);
            // change the scenes with assigned the next one with current one's name with small tricky
            // for instance when we on level 1 it means scene "1" and we goes to level 2 which means "2"
            // we have to use parse int for turning variable string to integer
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);

        }

        

    }

    // create the gameover"OyunBitti" method
    public void OyunBitti()
    {
        // call the finishing method 
        StartCoroutine(cagrılanmethod());

    }
     IEnumerator cagrılanmethod()
    {
        // stop the game 
        donencember.GetComponent<Dondurme>().enabled = false;
        anacember.GetComponent<anacember>().enabled = false;
        // check the truth 
        animator.SetTrigger("oyunbitti");
        kontrol = false;
        // delay the finisihing for showing the gameover animation
        yield return new WaitForSeconds(2);
        
        // turn back to main menu "AnaMenu"
        SceneManager.LoadScene("AnaMenu");

        
       
    }
}


