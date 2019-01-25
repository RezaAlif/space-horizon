using UnityEngine;
using System.Collections;

public class PlayerBomb : MonoBehaviour {
    public GameObject Peluru;
    public bool Launch;
    public float Timing;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Timing < 10)
        {
            Timing += Time.deltaTime;
            Launch = false;
        }

        if(Timing > 10)
        {
            Timing = 10;
            Launch = true;
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (Launch == true)
            {
                Instantiate(Peluru, transform.position, transform.rotation);
                Timing = 0;
            }
        }
    }
}
