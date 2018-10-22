using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Raycast {

	// Use this for initialization
	void Start () {
        SetAmmo(6);
    }
	
	// Update is called once per frame
	void Update () {
        SetAmmoText();

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (getAmmo())
            {
                Fire();
            }
        }

        SetRayCast("PistolAmmo");
    }
}
