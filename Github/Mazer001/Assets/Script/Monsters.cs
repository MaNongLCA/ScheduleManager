using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters : MonoBehaviour {

    public int damage;
    public int direction;
    private Rigidbody rig;

	// Use this for initialization
	void Start () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        transform.Rotate(new Vector3(5, direction, 5));
		transform.Translate (new Vector3 (1, 0, 1));
        Debug.Log("attack");
	}
}
