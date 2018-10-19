using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Shoot {

	// Use this for initialization
	void Start () {
        SetAmmo(20);   
    }
	
	// Update is called once per frame
	void Update () {
        SetAmmoText();

        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (getAmmo())
            {
                Fire();
            }
        }
    }
}
