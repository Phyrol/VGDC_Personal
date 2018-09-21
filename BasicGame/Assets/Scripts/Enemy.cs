using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    private int hp;

	// Use this for initialization
	void Start () {
        hp = 100;
	}
	
	// Update is called once per frame
	void Update () {

        //destroys the enemy object when hp == 0
		if (hp == 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {
            Destroy(collision.gameObject);
            hp -= 50;
        }
    }
}
