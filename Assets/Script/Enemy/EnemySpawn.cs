using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {
    public GameObject[] Enemy;
    public int Urutan;
    public int Max;
    public bool Musuh;
    public float timing;
    public int Current;

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Musuh == false)
        {
            Spawning();
        }
	}

    void Spawning()
    {
        timing = timing + Time.deltaTime;
        if (timing > 3 && Urutan == Current)
        {
            Urutan = Random.Range(0, Max);
            Instantiate(Enemy[Urutan], transform.position, transform.rotation);
            Musuh = true;
            timing = 0;
            Current = Urutan;
        }
    }
}
