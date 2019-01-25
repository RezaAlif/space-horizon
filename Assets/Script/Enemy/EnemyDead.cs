using UnityEngine;
using System.Collections;

public class EnemyDead : MonoBehaviour {
    public GameObject Explode;
    public AudioSource Hancur;
    public float Nyawa;

    // Use this for initialization
    void Start () {
        Hancur = GameObject.FindGameObjectWithTag("Blast").GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	    if(Nyawa <= 0)
        {
            Destroy(gameObject);
            Instantiate(Explode, transform.position, transform.rotation);
            Hancur.Play();
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pPeluru")
        {
            Nyawa -= 0.2f;
        }
    }
}
