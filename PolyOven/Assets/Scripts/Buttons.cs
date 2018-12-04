using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    pastryInfo cake;
    pastryInfo cookie;
    pastryInfo iceCream;

    public GameObject preFabSpawn;
    public GameObject cakeObject;
    public GameObject cookieObject;
    public GameObject iceCreamObject;
    GameObject newCake;
    GameObject newCookie;
    GameObject newIceCream;
    GameObject ovenManager = GameObject.FindGameObjectWithTag("OvenManager");

    private Vector3 spawnPoint = new Vector3(-6.121f, -0.14f, -6.605f);


    // Use this for initialization
    void Start () {
        cake.name = "Cake";
        cake.sweetnessLevel = 1;

        cookie.name = "Cookie";
        cookie.sweetnessLevel = 2;

        iceCream.name = "IceCream";
        iceCream.sweetnessLevel = 3;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Select()
    {
        if (transform.name.Equals("CakeButton"))
        {
            newCake = Instantiate(cakeObject, transform.position, transform.rotation);
            newCake.transform.SetParent(GameObject.FindGameObjectWithTag("OvenManager").transform, false);
        }
        if (transform.name.Equals("CookieButton"))
        {
            newCookie = Instantiate(cookieObject, spawnPoint, transform.rotation) as GameObject;
            newCookie.transform.SetParent(ovenManager.transform, false);
        }
        if (transform.name.Equals("IceCreamButton"))
        {
            newIceCream = Instantiate(iceCreamObject, spawnPoint, transform.rotation) as GameObject;
            newIceCream.transform.SetParent(ovenManager.transform, false);
        }
    }

    public void Clear()
    {
        cake.sweetnessLevel = 1;
        cookie.sweetnessLevel = 2;
        iceCream.sweetnessLevel = 3;
    }
}
