﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreArcade : MonoBehaviour
{

    public static int scoreAmount;
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
        scoreAmount = 0;
	Debug.Log("kontol");
	
    }

    // Update is called once per frame
    void Update()
    {
	scoreText.text = scoreAmount.ToString();
    	
    }
}
