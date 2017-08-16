using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Memory : MonoBehaviour {
    public InputField output;
    void Start()
    {
        output.text = PlayerPrefs.GetString("user_name", "Player1");
        Debug.Log("Text complete");
    }
}
