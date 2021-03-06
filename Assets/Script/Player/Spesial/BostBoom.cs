﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BostBoom : MonoBehaviour {
    public GameObject[] Peluru;
    public float Timing;
    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Speed);
        Timing += Time.deltaTime;
        if (Timing > 0.5)
        {
            Speed = 0;
            Peluru[0].SetActive(false);
            Peluru[1].SetActive(true);
        }
        if(Timing > 1.5f)
        {
            Destroy(gameObject);
        }
	}
}
