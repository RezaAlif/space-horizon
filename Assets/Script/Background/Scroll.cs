using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
    public float Speed;
    public float MaxDistance;
    public Vector3 StartPos;
    public float Speedy;
    public PauseMenu Pause;

	// Use this for initialization
	void Start () {
        Pause = GameObject.FindWithTag("Tembak").GetComponent<PauseMenu>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Speedy);

        if (transform.position.y < MaxDistance)
        {
            transform.position = StartPos;
        }

        if(Pause.Paused == true)
        {
            Speedy = 0;
        }
        else if(Pause.Paused == false)
        {
            Speedy = Speed;
        }
	}
}
