using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float Speed;
    public float Batas;
    public float Speedy;
    public PauseMenu Pause;

	// Use this for initialization
	void Start () {
        Pause = GameObject.FindWithTag("Tembak").GetComponent<PauseMenu>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Speedy);
        if(transform.localPosition.y > Batas)
        {
            Destroy(gameObject);
        }
        if(Pause.Paused == true)
        {
            Speedy = 0;
        }
        if(Pause.Paused == false)
        {
            Speedy = Speed;
        }
	}
}
