using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxisRotation : MonoBehaviour {

    private Vector3 NewPosition;
    public float s = 2;

	// Use this for initialization
	void Awake () {
        NewPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        ChangePos();
	}


    void ChangePos()
    {
        Vector3 Pos_a = new Vector3(100, 100, 100);
        Vector3 Pos_b = new Vector3(-100, 100, 100);
        if (Input.GetKey(KeyCode.W))
        {
            NewPosition = Pos_a;
        }
        if (Input.GetKey(KeyCode.S))
        {
            NewPosition = Pos_b;
        }

        transform.position = Vector3.Lerp(transform.position, NewPosition, Time.deltaTime * s);
    }
}
