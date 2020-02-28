using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dondurme : MonoBehaviour {
    // assign a rotating speed for creating difficult levels
	public float hız;

	void Update () {
        // connect the rotating speed with time and speed that we defined
		transform.Rotate (0, 0, hız*Time.deltaTime);
		
	}
}
