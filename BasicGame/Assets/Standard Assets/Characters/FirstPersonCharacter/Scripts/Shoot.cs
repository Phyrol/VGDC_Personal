using System;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

    //for shooting the bullet -- added for Lesson 1
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    private int ammo;
    private int maxAmmo;
    public Text ammoCount;
    private Boolean hasAmmo = true;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
    }

    public void SetAmmo(int _maxAmmo)
    {
        maxAmmo = _maxAmmo;
        ammo = maxAmmo;
    }

    public Boolean getAmmo()
    {
        if (ammo == 0)
        {
            hasAmmo = false;
        }
        return hasAmmo;
    }

    // Shoots a bullet -- added for Lesson 1
    public void Fire()
    {
        // Create the Bullet from the Bullet Prefab
        var bullet = Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        ammo--;

        // Add velocity to the bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 40;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }

    //reloads
    public void Reload()
    {
        ammo = maxAmmo;
    }

    //method for changing the ammo text
    public void SetAmmoText()
    {
        
        if (ammo == 0)
        {
            ammoCount.text = "Out of ammo";
        }
        else
        {
            ammoCount.text = "Ammo: " + ammo.ToString() + "/" + maxAmmo.ToString();
        }

    }
}
