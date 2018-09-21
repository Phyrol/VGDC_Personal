using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    private int hp;
    private int score;
    private int enemyCount;

    public Text winText;

	// Use this for initialization
	void Start () {
        hp = 100;
        enemyCount = 4;
        score = 0;
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {

        //destroys the enemy object when hp == 0
		if (hp == 0)
        {
            score++;
            Destroy(gameObject);
        }
        if (score == enemyCount)
        {
            SetWinText();
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

    void SetWinText()
    {
        winText.text = "You Win!";
    }
}
