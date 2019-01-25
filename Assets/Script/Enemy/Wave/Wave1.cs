using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : MonoBehaviour {
    public GameObject[] Enemy;
    public float Timing;
    public float[] Max;
    public int Urutan;
    public int Maks;
    public float Batas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Timing < Batas)
        {
            Timing += Time.deltaTime;
        }
		if(Timing >= Max[Urutan])
        {
            Enemy[Urutan].SetActive(true);
            Urutan += 1;
        }
        if(Timing >= Batas)
        {
            Timing = Batas;
            Urutan = Maks;
        }
	}
}
