using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImmediatMode : MonoBehaviour {

	void OnGUI()
    {
        if(GUI.Button(new Rect(0,0,50,50), "Hello")){
            Debug.Log("Success");
        }
    }
}
