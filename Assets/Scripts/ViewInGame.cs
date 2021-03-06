﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewInGame : MonoBehaviour {

    public Text coinLabel;
    public Text scoreLabel;
    public Text highscoreLabbel;

    void Update()
    {
        if(GameManager.instance.currentGameState == GameState.inGame){
            scoreLabel.text = PlayerController.instance.GetDistance().ToString("f0");
            coinLabel.text = GameManager.instance.collectedCoins.ToString();
            highscoreLabbel.text = PlayerPrefs.GetFloat("highscore", 0).ToString("f0");
            

        }
       
    }
}
