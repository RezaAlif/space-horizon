using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWave : MonoBehaviour {
    public float Timing;
    public GameObject[] Senjata;
    public int urutan;
    public int max;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing > 5)
        {
            urutan = Random.Range(0, max);
            Senjata[urutan].SetActive(true);
            Timing = 0;
        }
	}
}
