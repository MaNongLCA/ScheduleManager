using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveName : MonoBehaviour {

    [SerializeField]
    private Text input;

    public void SaveInput()
    {

        PlayerPrefs.SetString("user_name", input.text.ToString());
        Debug.Log("sAVED");
    }

}
