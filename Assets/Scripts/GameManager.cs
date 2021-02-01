using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player1")]
    public GameObject Player1;
    public GameObject Player1Goal;

    [Header("Player2")]
    public GameObject Player2;
    public GameObject Player2Goal;

    [Header("SocreUI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int player1Score;
    private int player2Score;

    public void Player1Scored()
    {
        player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        ResetPosition();
    }

    void ResetPosition()
    {
        ball.GetComponent<Ball>().Reset();
        Player1.GetComponent<Player>().Reset();
        Player2.GetComponent<Player>().Reset();
    }
}
