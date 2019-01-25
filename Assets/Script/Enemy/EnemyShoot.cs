using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {
    public GameObject Peluru;
    public float Timing;
    public float MaxTime;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Timing = Timing + Time.deltaTime;
        if (Timing > MaxTime)
        {
            Instantiate(Peluru, transform.position, transform.rotation);
            Timing = 0;
        }
    }
}
