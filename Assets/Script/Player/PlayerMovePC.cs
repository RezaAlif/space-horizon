using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovePC : MonoBehaviour {
    private float moveForce;
    public float maxX;
    public float maxY;
    public float minY;

    // Use this for initialization
    void Start () {
        moveForce = 10;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, moveForce);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    
}
