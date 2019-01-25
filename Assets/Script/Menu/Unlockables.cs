using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockables : MonoBehaviour {
    public GameObject Part;
    public int Bagian;
    public int max;

	// Use this for initialization
	void Start () {
        Bagian = PlayerPrefs.GetInt("PlayerPrefs_BAGIAN");
	}
	
	// Update is called once per frame
	void Update () {
		if(Bagian >= max)
        {
            Part.SetActive(true);
        }
        else
        {
            Part.SetActive(false);
        }
	}
}
