using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour {

    private Rigidbody rig;
    //public float force;

	// Use this for initialization
	void Awake () {
        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)) {
            rig.AddForce(new Vector3(0, 0, 10));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rig.AddForce(new Vector3(0, 0, -10));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rig.AddForce(new Vector3(-10, 0, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rig.AddForce(new Vector3(10, 0, 0));
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            //rig.AddExplosionForce(10.0f, other.gameObject.transform.position, 5.0f, 3.0f);
            /*Debug.Log("Expode");
            Vector3 pos = other.gameObject.transform.position;
            Collider[] nearby = Physics.OverlapSphere(pos, 5.0f);
            foreach(Collider hit in nearby)
            {
                Rigidbody r = hit.GetComponent<Rigidbody>();
                if (r != null)
                {
                    r.AddExplosionForce(10.0f, pos, 5.0f, 3.0f);
                }
            }*/
        }
    }
}
