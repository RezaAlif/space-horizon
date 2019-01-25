using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour {
    public float Timing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing = Timing + Time.deltaTime;
        if(Timing > 3)
        {
            Application.LoadLevel("MainMenu");
        }	
	}
}
