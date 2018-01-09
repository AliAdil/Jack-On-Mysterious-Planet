using System.Collections;
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
        }
        else if (newGameState == GameState.inGame)
        {
            // setup unity scene for inGame state
            menuCanvas.enabled = false;
           

        }
        else if (newGameState == GameState.gameOver)
        {
            // setup unity scene for gameOver state
            menuCanvas.enabled = false;
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


