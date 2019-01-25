using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {
    public EnemyDead Boss;
    public PlayerDead Player;

    public Text Hasil;
    public GameObject Restart;
    public GameObject Home;
    public int Bagian;
    public int Level;
    public string Prefs;
    public string Part;

	// Use this for initialization
	void Start () {
        Time.timeScale = 1;
        Level = PlayerPrefs.GetInt("PlayerPrefs_UNLOCK");
        Bagian = PlayerPrefs.GetInt("PlayerPrefs_BAGIAN");
        Prefs = PlayerPrefs.GetString(Part);
    }
	
	// Update is called once per frame
	void Update () {
	    if(Boss.Nyawa <= 0)
        {
            Jadi();
        }
        if(Player.Health <= 0)
        {
            Hasil.text = "Failed";
            Restart.SetActive(true);
            Time.timeScale = 0;
        }
	}

    void Jadi()
    {
        if (Prefs == "true")
        {
            Hasil.text = "Completed";
            Home.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Hasil.text = "Completed";
            Home.SetActive(true);
            Time.timeScale = 0;
            Bagian += 1;
            Level += 1;
            Prefs = "true";
            PlayerPrefs.SetInt("PlayerPrefs_UNLOCK",Level);
            PlayerPrefs.SetInt("PlayerPrefs_BAGIAN",Bagian);
            PlayerPrefs.SetString(Part,Prefs);
        }
    }

    public void Ulang(string Stage)
    {
        Application.LoadLevel(Stage);
    }

    public void Menu()
    {
        Application.LoadLevel("MainMenu");
    }
}
