using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    //for shooting the bullet -- added for Lesson 1
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // added for bullet for lesson 1
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Fire();
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
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 10;

        // Destroy the bullet after 2 seconds
        Destroy(bullet, 2f);
    }
}
