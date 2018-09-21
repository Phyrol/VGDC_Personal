using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    //for shooting the bullet -- added for Lesson 1
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private int ammo;
    private int maxAmmo;
    public Text ammoCount;

    private int score;
    public Text winText;

    // Use this for initialization
    void Start () {
        ammo = 5;
        maxAmmo = 5;
        SetAmmoText();
	}
	
	// Update is called once per frame
	void Update () {

        // added for bullet for lesson 1
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (ammo > 0)
            {
                Fire();
                ammo--;
            }
        }

        //uses methong SetAmmoText to change the text displaying ammo left
        if (ammo != 0)
        {
            SetAmmoText();
        }
        else
        {
            SetAmmoText();
        }
    }

    // Shoots a bullet -- added for Lesson 1
    void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 20;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }

    //reloads
    public void Reload()
    {
        ammo = maxAmmo;
    }

    //method for changing the ammo text
    void SetAmmoText()
    {
        if (ammo == 0)
        {
            ammoCount.text = "Out of ammo";
        }
        else
        {
            ammoCount.text = "Ammo: " + ammo.ToString() + "/5";
        }

    }
}
