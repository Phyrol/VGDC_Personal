using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : Gun {

    //added for lessong 3, using raycast **********
    private readonly float raycastLength = 10f;

    private string ammoType;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetRayCast(string _ammoType)
    {
        ammoType = _ammoType;

        //added for lesson 3, using raycast
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastLength))
        {
            // checks if the object has the tag ammo
            if (hit.collider.gameObject.tag.Equals(ammoType))
            {
                // checks for 'e' to be pressed
                if (Input.GetKeyDown("e"))
                {
                    Reload();
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
