using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZigZag : MonoBehaviour {
    public float Timing;
    public bool Kanan;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
		if(Timing > 0.5)
        {
            if (Kanan == true)
            {
                transform.eulerAngles = new Vector3(0, 0, 115);
                Timing = 0;
                Kanan = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 245);
                Timing = 0;
                Kanan = false;
            }
        }
    }
}
