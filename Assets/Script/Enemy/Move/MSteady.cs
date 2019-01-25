using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MSteady : MonoBehaviour {
    public float Speed;
    public float[] Batas;
    public bool Turn;
    public float Timing;
    public float Kecepatan;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed);
        if (transform.localPosition.y > Batas[0])
        {
            Speed = 0;
            Timing -= Time.deltaTime;
            Turn = true;
        }
        if(Timing <= 0)
        {
            Speed = Kecepatan;
            Timing = 0;
        }
        if (transform.localPosition.y > Batas[1])
        {
            Destroy(gameObject);
        }
    }
}
