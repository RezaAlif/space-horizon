using UnityEngine;
using System.Collections;

public class ShootConfig : MonoBehaviour {
    public bool Tembak;
    public Transform BombSpawn;
    public PlayerBomb Bomba;
    public PlayerBomb2 Bomba2;
    public float Timing;

	// Use this for initialization
	void Start () {
        if (Bomba2 == null)
        {
            Bomba = GameObject.FindWithTag("BombSpawn").GetComponent<PlayerBomb>();
        }
        if(Bomba == null)
        {
            Bomba2 = GameObject.FindWithTag("BombSpawn").GetComponent<PlayerBomb2>();
        }
        BombSpawn = GameObject.FindWithTag("BombSpawn").transform;
    }
	
	// Update is called once per frame
	void Update () {
	    if(Timing < 10)
        {
            Timing = Timing + Time.deltaTime;
        }
        else
        {
            Timing = 10;
        }
	}

    public void Shoot()
    {
        Tembak = true;
    }

    public void Nah()
    {
        Tembak = false;
    }

    public void Bomb()
    {
        if (Bomba != null)
        {
            if (Timing == 10)
            {
                Instantiate(Bomba.Peluru, BombSpawn.position, BombSpawn.rotation);
                Timing = 0;
            }
        }
        if (Bomba2 != null)
        {
            if (Timing == 10)
            {
                Bomba2.Peluru.SetActive(true);
                Timing = 0;
            }
        }
    }
}
