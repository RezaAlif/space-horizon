using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTurn : MonoBehaviour {
    public float Timing;
    public float Max;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing >= Max)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
	}
}
