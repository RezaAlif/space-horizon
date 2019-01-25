using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerDead : MonoBehaviour {
    public float Health;
    public float[] Damage;
    public GameObject Plane;
    public GameObject Explode;
    public Image Darah;
    public AudioSource Hancur;
    public int pilih;

	// Use this for initialization
	void Start () {
        Hancur = GameObject.FindGameObjectWithTag("Blast").GetComponent<AudioSource>();
        pilih = PlayerPrefs.GetInt("PlayerPrefs_HEALTH");
        Damage[0] = 0.02f;
        Damage[1] = 0.015f;
        Damage[2] = 0.01f;
    }
	
	// Update is called once per frame
	void Update () {
        Darah.fillAmount = Health;
	    if(Health <= 0)
        {
            Cursor.visible = true;
            Destroy(Plane);
            Instantiate(Explode, transform.position, transform.rotation);
            Hancur.Play();
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ePeluru")
        {
            Health -= Damage[pilih];
        }
    }
}
