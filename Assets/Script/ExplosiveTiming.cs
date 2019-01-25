using UnityEngine;
using System.Collections;

public class ExplosiveTiming : MonoBehaviour {
    private float Timing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Timing = Timing + Time.deltaTime;
        if(Timing > 3)
        {
            Destroy(gameObject);
        }
	}
}
