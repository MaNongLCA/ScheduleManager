using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LocalControl : NetworkBehaviour{

   // private Rigidbody r;
    //public Camera cam;
	// Use this for initialization
	void Start () {
    //r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
			return;
			//Debug.Log ("hello world");
        }
        float hor = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        float ver = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;
        transform.Translate(new Vector3(hor, 0, ver));

        /*if (Input.GetKey(KeyCode.W))
        {
            r.AddForce(0, 0, 10);
        }
        if (Input.GetKey(KeyCode.S))
        {
            r.AddForce(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.D))
        {
            r.AddForce(10, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            r.AddForce(-10, 0, 0);
        }*/



        /*Vector3 dif = gameObject.transform.position - cam.transform.position;
        cam.transform.position = gameObject.transform.position + dif;*/

    }

    /*public override void OnStartLocalPlayer()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }*/
}
