using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour {

    public Transform t;
    private Vector3 diff;
    void Start()
    {
        diff = transform.position - t.position;
    }
	void LateUpdate () {
        transform.position = t.position+diff;
	}
}
