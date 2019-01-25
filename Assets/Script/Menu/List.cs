using UnityEngine;
using System.Collections;

public class List : MonoBehaviour {
    public GameObject Menu;
    public GameObject Level;
    public GameObject Plane;
    public GameObject[] SpaceShip;
    public GameObject Kapal;
    public GameObject Locked;

    public int Pesawat;
    public int Maks;
    public int Max;

    // Use this for initialization
    void Start () {
        Max = PlayerPrefs.GetInt("PlayerPrefs_PESAWAT");
        if (Max == 0)
        {
            Max = 1;
            PlayerPrefs.SetInt("PlayerPrefs_PESAWAT", 1);
        }
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void level()
    {
        Menu.SetActive(false);
        Level.SetActive(true);
    }

    public void plane()
    {
        Menu.SetActive(false);
        Plane.SetActive(true);
        Kapal.SetActive(true);
    }

    public void back()
    {
        Plane.SetActive(false);
        Level.SetActive(false);
        Menu.SetActive(true);
    }

    public void Back()
    {
        Application.LoadLevel("Menu");
    }

    public void PilihLevel(string Level)
    {
        Application.LoadLevel(Level);
    }

    public void Next()
    {
        if(Pesawat < Maks)
        {
            Pesawat = Pesawat + 1;
            SpaceShip[Pesawat].SetActive(true);
            SpaceShip[Pesawat - 1].SetActive(false);
            Locked.SetActive(false);
        }
        else
        {
            Pesawat = Maks;
        }
    }

    public void Prev()
    {
        if (Pesawat > 0)
        {
            Pesawat = Pesawat - 1;
            SpaceShip[Pesawat].SetActive(true);
            SpaceShip[Pesawat + 1].SetActive(false);
            Locked.SetActive(false);
        }
        else
        {
            Pesawat = 0;
        }
    }

    public void PilihPesawat()
    {
        if (Pesawat < Max)
        {
            PlayerPrefs.SetInt("PlayerPrefs_PLANE", Pesawat);
            Plane.SetActive(false);
            Level.SetActive(false);
            Kapal.SetActive(false);
            Menu.SetActive(true);
        }
        else
        {
            Locked.SetActive(true);
        }
    }
}
