using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int firstScore;
    public int secondScore;
    public int thirdScore;
    public int fourthScore;
    public int playerAmount = 4;
    public Collider tembokBawah;
    public Collider tembokAtas;
    public Collider tembokKanan;
    public Collider tembokKiri;
    public bool player1 = true;
    public bool player2 = true;
    public bool player3 = true;
    public bool player4 = true;
    public FirstPaddle paddleBawah;
    public SecondPaddle paddleAtas;
    public ThirdPaddle paddleKanan;
    public FourthPaddle paddleKiri;

    public GameOverManager manager;

    public int maxScore;

    private void Update()
    {
        GameOver();
    }

    public void Player1Score(int increment)
    {
        firstScore += increment;
        if(firstScore >= maxScore)
        {
            tembokBawah.isTrigger = false;
            playerAmount -= 1;
            player1 = false;
            paddleBawah.speed = 0;
        }
    }

    public void Player2Score(int increment)
    {
        secondScore += increment;
        if (secondScore >= maxScore)
        {
            tembokAtas.isTrigger = false;
            playerAmount -= 1;
            player2 = false;
            paddleAtas.speed = 0;
        }
    }

    public void Player3Score(int increment)
    {
        thirdScore += increment;
        if (thirdScore >= maxScore)
        {
            tembokKanan.isTrigger = false;
            playerAmount -= 1;
            player3 = false;
            paddleKanan.speed = 0;
        }
    }

    public void Player4Score(int increment)
    {
        fourthScore += increment;
        if (fourthScore >= maxScore)
        {
            tembokKiri.isTrigger = false;
            playerAmount -= 1;
            player4 = false;
            paddleKiri.speed = 0;
        }
    }

    public void GameOver()
    {
        if(playerAmount == 1)
        {
            if(player1)
            {
                manager.setup("Player 1");
            } else if (player2)
            {
                manager.setup("Player 2");
            } else if (player3)
            {
                manager.setup("Player 3");
            } else if (player4)
            {
                manager.setup("Player 4");
            } 
        }
    }
}
