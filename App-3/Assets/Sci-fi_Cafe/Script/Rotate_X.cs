using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_X: MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(2.0f, 0, 0);
    }
}
