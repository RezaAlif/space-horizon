using UnityEngine;
using System.Collections;

public class Percakapan : MonoBehaviour {
    public GameObject[] Teks;
    public int Urutan;
    public int Max;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Lanjut(string Level)
    {
        if(Urutan > Max)
        {
            Application.LoadLevel(Level);
        }
        else
        {

            Urutan = Urutan + 1;
            Teks[Urutan].SetActive(true);
            Teks[Urutan - 1].SetActive(false);
        }
    }

    public void Ending()
    {
        Application.LoadLevel("Menu");
    }
}
