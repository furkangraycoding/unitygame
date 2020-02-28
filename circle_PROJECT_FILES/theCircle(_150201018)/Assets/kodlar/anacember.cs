using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anacember : MonoBehaviour {
    // create a smallcircle "kucukcember" and gamemanager "OyunYonetici" object for define them with their tags
    public GameObject kucukcember;
    GameObject OyunYonetici;

    // assign the tags to the objects
	void Start () {
        OyunYonetici = GameObject.FindGameObjectWithTag("oyunyoneticisitag");
	}
	
	
	void Update () {
        // create a mouse move for fire the smallcircle
        if (Input.GetButtonDown("Fire1")){
            // create a smallcircles
            kucukcemberolustur();
        }
    }
    // create the method for creating smallcircles
    void kucukcemberolustur()
    {
        // crate a smallcircles and put its to smallcircle subfolder
        Instantiate(kucukcember, transform.position, transform.rotation);
        // Show the rest of smallcircles for hitting in the smallcircle
        OyunYonetici.GetComponent<OyunYoneticisi>().kucuktextgosterme();
       
    }
}
