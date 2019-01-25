using UnityEngine;
using System.Collections;

public class BombDuration : MonoBehaviour {
    public float Timing;
    public GameObject Peluru;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Timing = Timing + Time.deltaTime;

        if (Timing > 2)
        {
            Peluru.SetActive(false);
            Timing = 0;
        }
    }
}
