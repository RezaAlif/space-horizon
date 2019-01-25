using UnityEngine;
using System.Collections;

public class BossTurret : MonoBehaviour {
    public Remains Count;
    public GameObject Explode;
    public AudioSource Hancur;
    public float Helath;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pPeluru")
        {
            Count.Enemies = Count.Enemies + 1;
        }
    }
}
