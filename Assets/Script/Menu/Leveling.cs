using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leveling : MonoBehaviour {
    public int Current;
    public int Preset;
    public GameObject[] Obj;

	// Use this for initialization
	void Start () {
        Current = PlayerPrefs.GetInt("PlayerPrefs_UNLOCK");
	}
	
	// Update is called once per frame
	void Update () {
		if(Current >= Preset)
        {
            Obj[0].SetActive(false);
            Obj[1].SetActive(true);
        }
        if (Current < Preset)
        {
            Obj[0].SetActive(true);
            Obj[1].SetActive(false);
        }
    }
}
