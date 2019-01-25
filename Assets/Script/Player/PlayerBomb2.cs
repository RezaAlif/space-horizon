using UnityEngine;
using System.Collections;

public class PlayerBomb2 : MonoBehaviour {
    public GameObject Peluru;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            Peluru.SetActive(true);
        }

    }
}
