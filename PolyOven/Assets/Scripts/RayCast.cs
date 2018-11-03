using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {

    readonly float rayDist = 10f;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        PlayerRay();
	}

    void PlayerRay()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, rayDist))
        {
            var hitReader = hit.collider.gameObject.GetComponent<Buttons>();
            if (Input.GetKeyDown("e"))
            {
                if (hit.transform.tag.Equals("Button"))
                {
                    hitReader.Select();
                }
            }
        }
    }
}
