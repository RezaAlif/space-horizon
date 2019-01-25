using UnityEngine;
using System.Collections;

public class Unlo : MonoBehaviour {
    public int Max;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OK()
    {
        PlayerPrefs.SetInt("PlayerPrefs_PESAWAT", Max);
    }
}
