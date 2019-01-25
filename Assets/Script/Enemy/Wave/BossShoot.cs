using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour {
    public float timing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timing += Time.deltaTime;
	    if(timing > 5)
        {
            gameObject.SetActive(false);
            timing = 0;
        }	
	}
}
