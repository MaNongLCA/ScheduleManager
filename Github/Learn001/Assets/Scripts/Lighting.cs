using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighting : MonoBehaviour {

    private Light l;
    private Color NextColor;
    private float NextIntense;
    private Vector3 Nextpos;
    public float spe;

	// Use this for initialization
	void Awake () {
        l = GetComponent<Light>();
        NextColor = Color.green;
        NextIntense = 1.0f;
        Nextpos = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        Color ca = Color.green;
        Color cb = Color.magenta;
        float jim = 1.0f;
        float blah = 8.0f;
        Vector3 va = new Vector3(0, 0, 0);
        Vector3 vb = new Vector3(20, 0, 0);

        if(l.color == cb)
        {
            NextColor = ca;
            NextIntense = jim;
            Nextpos = va;
        }
        else if(l.color == ca)
        {
            NextColor = cb;
            NextIntense = blah;
            Nextpos = vb;
        }
        l.color = Color.Lerp(l.color, NextColor, spe);
        l.intensity = Mathf.Lerp(l.intensity, NextIntense, spe);
        transform.position = Vector3.Lerp(transform.position, Nextpos, spe);
    }
}
