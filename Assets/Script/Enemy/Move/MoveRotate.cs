using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotate : MonoBehaviour {
    public float Speed;
    public float Preset;
    public float Max;
    public PauseMenu Pause;

    // Use this for initialization
    void Start () {
        Pause = GameObject.FindWithTag("Tembak").GetComponent<PauseMenu>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, Speed * Time.deltaTime));
        if(transform.rotation.z > Max)
        {
            Speed = -Preset;
        }
        if(transform.rotation.z < -Max)
        {
            Speed = Preset;
        }
        if (Pause.Paused == true)
        {
            Speed = 0;
        }
        if (Pause.Paused == false)
        {
            Speed = Preset;
        }
    }
}
