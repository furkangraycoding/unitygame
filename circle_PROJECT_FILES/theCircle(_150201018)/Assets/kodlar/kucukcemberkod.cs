using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour {
    // add physics rules and define variables such as speed and control equation
    Rigidbody2D fizik;
    public float hız;
    bool hareketkontrol = false;
    // create a gameobject as oyunYoneticisi " game manager"
     GameObject oyunYoneticisi;
	void Start () {
        // defined fizik component as a rigidbody2d 
        fizik = GetComponent<Rigidbody2D>();
        // assign the object with tag
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
	}

	
	void FixedUpdate () {
        // kontrol the small circle's position with if statement and multiply with speed and time
        if (!hareketkontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up *hız* Time.deltaTime);
        }
		
	}


    void OnTriggerEnter2D(Collider2D col)
    {
        // assign the collider with rotating circle's tag
        if (col.tag == "donencembertag")
        {
            // create a equation when small one hit the big one,it became a part of big(rotating) circle
            transform.SetParent(col.transform);
            // approve with true statement
            hareketkontrol = true;
        }
        if (col.tag == "kucukcembertag")
        {
            // crate a equation for gameing over with gameobject and OyunBitti method when smallcircles hit to each other
            oyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();

        }
    }
}
