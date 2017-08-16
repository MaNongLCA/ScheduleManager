using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    public GameObject floor;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Portable"))
        {
            //floor.SetActive(false);
            //other.gameObject.SetActive(false);

            DisableFloor next = other.gameObject.GetComponentInParent(typeof(DisableFloor)) as DisableFloor;
            //MeshFilter next = other.gameObject.GetComponentInParent(typeof(MeshFilter)) as MeshFilter;
            if (next != null)
            {
                next.disable_floor();
                Debug.Log("Next");
            }
        }
    }
}
