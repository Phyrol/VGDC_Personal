using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Shoot {

	// Use this for initialization
	void Start () {
        ammo = maxAmmo;
        maxAmmo = 20;
        SetAmmoText();
    }
	
	// Update is called once per frame
	void Update () {
        Fire();
	}
}
