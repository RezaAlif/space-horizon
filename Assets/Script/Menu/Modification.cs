using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modification : MonoBehaviour {
    public GameObject Menu;
    public GameObject Pesawat;
    public GameObject[] Ammo;
    public int Pilihan;

	// Use this for initialization
	void Start () {
		Pilihan = PlayerPrefs.GetInt("PlayerPrefs_GUN");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Gun(int Pilih)
    {
        PlayerPrefs.SetInt("PlayerPrefs_GUN", Pilih);
        Pilihan = Pilih;
        Ammo[0].SetActive(false);
        Ammo[1].SetActive(false);
        Ammo[2].SetActive(false);
    }

    public void Body(int Choose)
    {
        PlayerPrefs.SetInt("PlayerPrefs_HEALTH", Choose);
    }

    public void ActiveObj(GameObject Jenis)
    {
        Menu.SetActive(false);
        Jenis.SetActive(true);
        Pesawat.SetActive(true);
        Ammo[Pilihan].SetActive(true);
    }

    public void Reward(GameObject Obj)
    {
        Obj.SetActive(true);
        Menu.SetActive(false);
    }

    public void Back(GameObject List)
    {
        List.SetActive(false);
        Menu.SetActive(true);
        Pesawat.SetActive(false);
    }
}
