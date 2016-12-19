using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    public s_Player player;
    public Score score;

    void OnCollisionEnter(Collision col)
    {
        Ball ball = col.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(0f, 5f, 0f);

            if (player == s_Player.Player1) score.scorePlayer2++;
            else if (player == s_Player.Player2) score.scorePlayer1++;
        }
    }
}