using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWithoutPhysics : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hor, 0, ver));
	}
}
