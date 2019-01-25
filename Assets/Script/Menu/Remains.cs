using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Remains : MonoBehaviour {
    public Result Hasil;
    public int Save;
    public int Max;

    public GameObject Player;
    public GameObject Enemy;

    public int Enemies;
    public float Timing;
    public int MaxEnemy;

    public Text Waktu;

	// Use this for initialization
	void Start () {
        Max = PlayerPrefs.GetInt("PlayerPrefs_LEVEL");
    }
	
	// Update is called once per frame
	void Update () {
        Player = GameObject.FindGameObjectWithTag("Player");
        Timing = Timing - Time.deltaTime;
        Waktu.text = Timing.ToString();
	    if(Enemies > MaxEnemy)
        {
            Cursor.visible = true;
            Enemy.SetActive(false);
            if(Save > Max)
            {
                PlayerPrefs.SetInt("PlayerPrefs_LEVEL", Save);
            }
        }
        if(Timing < 0)
        {
            Cursor.visible = true;
            Destroy(Player);
            Enemy.SetActive(false);
        }
	}
}
