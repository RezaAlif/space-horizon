using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batu : MonoBehaviour {
    public GameObject[] list;
    public int current;
    public int Max;
    public float Timing;
    public float Line;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing > Line)
        {
            current = Random.Range(0, Max);
            Instantiate(list[current],transform.position,transform.rotation);
            Timing = 0;
        }
	}
}
