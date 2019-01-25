using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour {
    public Animator Turret;

    public Remains Remain;
    public Image Damage;

    public int Turn;
    public int Current;
    public int Max;

    public float time;

	// Use this for initialization
	void Start () {
        Turret = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        time = time + Time.deltaTime;
        if (time > 3 && Turn == Current)
        {
            Turn = Random.Range(0, Max);
            Turret.SetInteger("Turn", Turn);
            time = 0;
            Current = Turn;
        }

        Damage.fillAmount = Remain.Enemies / 200f;
    }
}
