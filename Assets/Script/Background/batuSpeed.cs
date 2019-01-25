using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batuSpeed : MonoBehaviour {
    public float Speed;
    public float MaxDistance;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Speed);

        if (transform.position.y < MaxDistance)
        {
            Destroy(gameObject);
        }
    }
}
