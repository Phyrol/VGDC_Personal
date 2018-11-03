using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

    pastryInfo cake;
    pastryInfo cookie;
    pastryInfo iceCream;

    public GameObject preFabSpawn;

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

        }
    }

    public void Clear()
    {
        cake.sweetnessLevel = 1;
        cookie.sweetnessLevel = 2;
        iceCream.sweetnessLevel = 3;
    }
}
