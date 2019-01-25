using UnityEngine;
using System.Collections;

public class EnemyCount : MonoBehaviour {
    public int Count;
    public EnemySpawn Spawn;
    public Remains Remain;

	// Use this for initialization
	void Start () {
        Remain = GameObject.FindGameObjectWithTag("Remain").GetComponent<Remains>();
        Spawn = GameObject.FindGameObjectWithTag("sEnemy").GetComponent<EnemySpawn>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(Count <= 0)
        {
            Spawn.Musuh = false;
            Destroy(gameObject);
            Remain.Enemies = Remain.Enemies + 1;
        }
	}
}
