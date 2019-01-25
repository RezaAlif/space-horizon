using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public int Volum;
    public Image Suara;
    public Sprite[] SuaraObj;
    public int First;
    public GameObject Menu;

    // Use this for initialization
    void Start () {
        Volum = PlayerPrefs.GetInt("PlayerPrefs_AUDIO");
        First = PlayerPrefs.GetInt("PlayerPrefs_FIRST");
        if(First <= 0)
        {
            Volum = 1;
            PlayerPrefs.SetInt("PlayerPrefs_FIRST",1);
            PlayerPrefs.SetInt("PlayerPrefs_AUDIO", Volum);
            Suara.sprite = SuaraObj[Volum];
        }
        if(First >= 1)
        {
            AudioListener.volume = Volum;
            Suara.sprite = SuaraObj[Volum];
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Mulai(string Stage)
    {
        Application.LoadLevel(Stage);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void link(string Link)
    {
        Application.OpenURL(Link);
    }

    public void Audio()
    {
        if (Volum > 0)
        {
            Volum = 0;
            AudioListener.volume = Volum;
            Suara.sprite = SuaraObj[Volum];
            PlayerPrefs.SetInt("PlayerPrefs_AUDIO", Volum);
        }
        else
        {
            Volum = 1;
            AudioListener.volume = Volum;
            Suara.sprite = SuaraObj[Volum];
            PlayerPrefs.SetInt("PlayerPrefs_AUDIO", Volum);
        }
    }

    public void ActiveObj(GameObject Jenis)
    {
        Menu.SetActive(false);
        Jenis.SetActive(true);
    }

    public void Back(GameObject List)
    {
        List.SetActive(false);
        Menu.SetActive(true);

    }
}
