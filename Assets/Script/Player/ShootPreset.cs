using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPreset : MonoBehaviour {
    public GameObject[] Peluru;
    public int Preset;

	// Use this for initialization
	void Start () {
        Preset = PlayerPrefs.GetInt("PlayerPrefs_GUN");
    }
	
	// Update is called once per frame
	void Update () {
        Peluru[Preset].SetActive(true);
	}
}
