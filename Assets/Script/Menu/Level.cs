using UnityEngine;
using System.Collections;

public class Level : MonoBehaviour {
    public int Lvl;
    public int Req;

    public GameObject LvlObject;

	// Use this for initialization
	void Start () {
        Lvl = PlayerPrefs.GetInt("PlayerPrefs_LEVEL");
    }
	
	// Update is called once per frame
	void Update () {
	    if(Lvl < Req)
        {
            LvlObject.SetActive(false);
        }
        else
        {
            LvlObject.SetActive(true);
        }
	}
}
