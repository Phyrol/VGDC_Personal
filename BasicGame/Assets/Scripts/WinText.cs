using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour {

    public Text winText;
    private int score;

    // Use this for initialization
    void Start () {
        score = 0;
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.childCount == 0)
        {
            SetWinText();
        }
	}

    void SetWinText()
    {
        winText.text = "You Win!";
    }
}
