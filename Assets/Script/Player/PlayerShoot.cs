using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
    public GameObject Peluru;
    public float Timing;
    public float MaxTime;
    public AudioSource Tembak;

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        if(Tembak == null)
        {
            Debug.Log("Nol");
        }
        Timing = Timing + Time.deltaTime;
        if (Timing > MaxTime)
        {
            Instantiate(Peluru, transform.position, transform.rotation);
            Timing = 0;
            Tembak.Play();
        }
    }
}
