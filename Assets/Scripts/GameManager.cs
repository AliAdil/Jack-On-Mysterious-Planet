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
    public GameState currentGameState = GameState.menu;
    
    // for making simple access to the GameManager instance from anywhere in our code.
    public static GameManager instance;

    void Awkae()
    {
        instance = this;
    }

    void Start()
    {
        StartGame();
    }
    //called to start the game
    public void StartGame()
    {
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
        }
        else if (newGameState == GameState.inGame)
        {
            // setup unity scene for inGame state
        }
        else if (newGameState == GameState.gameOver)
        {
            // setup unity scene for gameOver state
        }
    }
}

