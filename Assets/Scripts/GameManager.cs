﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    menu,
    inGame,
    gameOver
}

public class GameManager : MonoBehaviour
{
    
    
    // for making simple access to the GameManager instance from anywhere in our code.
    public static GameManager instance;
    public GameState currentGameState = GameState.menu;
    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas GameOverCanvas;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
        currentGameState = GameState.menu;

       
      
    }
    //called to start the game
    public void StartGame()
    {
        PlayerController.instance.StartGame();
        SetGameState(GameState.inGame);
        
    }

 

    //called when player die
    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    //called when player decide to go back to the menu 
    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //setup Unity scene for menu state
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            GameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            // setup unity scene for inGame state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            GameOverCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver)
        {
            // setup unity scene for gameOver state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            GameOverCanvas.enabled = true;
        }
        currentGameState= newGameState;
    }
    void Update()
    {
        if (Input.GetButtonDown("s"))
        {
           // currentGameState = GameState.inGame;
            StartGame();
        }
    }

    
}


