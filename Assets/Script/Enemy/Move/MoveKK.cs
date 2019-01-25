using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKK : MonoBehaviour {
    public float Move;
    public float MaxMove;
    public float MinMove;
    public PauseMenu Pause;

    // Use this for initialization
    void Start () {
        Pause = GameObject.FindWithTag("Tembak").GetComponent<PauseMenu>();
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * Move);
        if (transform.localPosition.x < MinMove)
        {
            if (Pause.Paused == true)
            {
                Move = 0;
            }
            if (Pause.Paused == false)
            {
                Move = 0.05f;
            }
        }
        if (transform.localPosition.x > MaxMove)
        {
            if (Pause.Paused == true)
            {
                Move = 0;
            }
            if (Pause.Paused == false)
            {
                Move = -0.05f;
            }
        }
    }
}
