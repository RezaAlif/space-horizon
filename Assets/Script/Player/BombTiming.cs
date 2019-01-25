using UnityEngine;
using System.Collections;

public class BombTiming : MonoBehaviour {
    public float Timing;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Timing = Timing + Time.deltaTime;

        if (Timing > 2)
        {
            Destroy(gameObject);
        }
    }
}
