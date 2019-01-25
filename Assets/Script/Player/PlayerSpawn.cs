using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {
    public int Pesawat;
    public GameObject[] Plane;

	// Use this for initialization
	void Start () {
        Pesawat = PlayerPrefs.GetInt("PlayerPrefs_PLANE");
        Instantiate(Plane[Pesawat]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
