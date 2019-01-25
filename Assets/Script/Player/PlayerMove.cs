using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMove : MonoBehaviour {
    public float moveForce;
    public float maxX;
    public float maxZ;
    public Rigidbody myRigid;

	// Use this for initialization
	void Start () {
        myRigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.acceleration.x * moveForce * Time.deltaTime, 0, 0);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        pos.z = Mathf.Clamp(pos.z, -maxZ, maxZ);
        transform.position = pos;
	}
}
