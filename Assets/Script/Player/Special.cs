using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Special : MonoBehaviour {
    public bool[] Spesial;
    public float[] Timing;
    public Image[] SPecUI;
    public GameObject[] SpecObj;
    public GameObject[] Bost;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Charge();
        PerUIan();
        SpecOn();
        SpecOff();
	}

    void PerUIan()
    {
        SPecUI[0].fillAmount = Timing[0];
        SPecUI[1].fillAmount = Timing[1];
        SPecUI[2].fillAmount = Timing[2];
        SPecUI[3].fillAmount = Timing[3];
    }

    void SpecOn()
    {
        if (Spesial[0] == true)
        {
            SpecObj[0].SetActive(true);
            Timing[0] -= Time.deltaTime * 0.3f;
        }
        if (Spesial[1] == true)
        {
            SpecObj[1].SetActive(false);
            Timing[1] -= Time.deltaTime * 0.3f;
        }
        if (Spesial[2] == true)
        {
            SpecObj[2].SetActive(true);
            Timing[2] -= Time.deltaTime * 0.3f;
        }
        if (Spesial[3] == true)
        {
            SpecObj[3].SetActive(true);
            Timing[3] -= Time.deltaTime * 0.1f;
        }
        if (Spesial[4] == true)
        {
            Instantiate(SpecObj[4], transform.position, transform.rotation);
            Timing[4] = 0;
            Spesial[4] = false;
        }
    }

    void SpecOff()
    {
        if(Timing[0] <= 0)
        {
            Spesial[0] = false;
            SpecObj[0].SetActive(false);
        }
        if(Timing[1] <= 0)
        {
            Spesial[1] = false;
            SpecObj[1].SetActive(true);
        }
        if (Timing[2] <= 0)
        {
            Spesial[2] = false;
            SpecObj[2].SetActive(false);
        }
        if (Timing[3] <= 0)
        {
            Spesial[3] = false;
            SpecObj[3].SetActive(false);
        }
        if(Timing[4] < 1)
        {
            Bost[0].SetActive(false);
            Bost[1].SetActive(true);
        }
    }

    void Charge()
    {
        if (Spesial[0] == false)
        {
            Timing[0] += Time.deltaTime * 0.02f;
            if(Timing[0] >= 1)
            {
                Timing[0] = 1;
            }
        }
        if (Spesial[1] == false)
        {
            Timing[1] += Time.deltaTime * 0.05f;
            if (Timing[1] >= 1)
            {
                Timing[1] = 1;
            }
        }
        if (Spesial[2] == false)
        {
            Timing[2] += Time.deltaTime * 0.03f;
            if (Timing[2] >= 1)
            {
                Timing[2] = 1;
            }
        }
        if (Spesial[3] == false)
        {
            Timing[3] += Time.deltaTime * 0.04f;
            if (Timing[3] >= 1)
            {
                Timing[3] = 1;
            }
        }
        if (Spesial[4] == false)
        {
            Timing[4] += Time.deltaTime * 0.02f;
            if (Timing[4] >= 1)
            {
                Timing[4] = 1;
                Bost[0].SetActive(true);
                Bost[1].SetActive(false);
            }
        }
    }

    public void Blast()
    {
        Spesial[0] = true;
    }

    public void Paran()
    {
        Spesial[1] = true;
    }

    public void Assist()
    {
        Spesial[2] = true;
    }

    public void Boost()
    {
        Spesial[4] = true;
    }

    public void Boom()
    {
        Spesial[3] = true;
    }
}
