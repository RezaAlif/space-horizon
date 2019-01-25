using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
    public bool Paused;
    public int Volum;
    public Image Suara;
    public Sprite[] SuaraObj;

    // Use this for initialization
    void Start () {
        Volum = PlayerPrefs.GetInt("PlayerPrefs_AUDIO");
        AudioListener.volume = Volum;
        Suara.sprite = SuaraObj[Volum];
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Jeda(GameObject Pause)
    {
        Pause.SetActive(true);
        Time.timeScale = 0;
        AudioListener.volume = 0;
        Paused = true;
    }

    public void LV(string Scene)
    {
        Application.LoadLevel(Scene);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Resume(GameObject Pause)
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
        AudioListener.volume = Volum;
        Paused = false;
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
}
