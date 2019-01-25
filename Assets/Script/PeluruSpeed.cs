using UnityEngine;
using System.Collections;

public class PeluruSpeed : MonoBehaviour {
    public float MaxX;
    public float MaxZ;
    public float speed;
    public float Speedy;
    public PauseMenu Pause;

    // Use this for initialization
    void Start () {
        Pause = GameObject.FindWithTag("Tembak").GetComponent<PauseMenu>();
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = transform.TransformDirection(new Vector2(0, Speedy));

        if(transform.position.x > MaxX)
        {
            Destroy(gameObject);
        }

        if (transform.position.y > MaxZ)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -MaxX)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -MaxZ)
        {
            Destroy(gameObject);
        }

        if (Pause.Paused == true)
        {
            Speedy = 0;
        }
        if (Pause.Paused == false)
        {
            Speedy = speed;
        }
    }
}
