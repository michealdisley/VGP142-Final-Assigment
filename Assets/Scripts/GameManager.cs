using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool doubleSpeed;
    private bool incSize;
    private bool decSize;

    private bool powerUpActive;

    private float powerLengthcounter;
    private Vector3 currentBallSpeed;
    // private Vector3 SpeedBoost;

    private GameObject paddleSize;

    private Ball ballcontrol;
    private Player PlayerSize;

    // Use this for initialization
    void Start ()
    {
        ballcontrol = FindObjectOfType<Ball>();
        PlayerSize = FindObjectOfType<Player>();

        if(powerUpActive== true)
        {
            powerLengthcounter -= Time.deltaTime;

            if(doubleSpeed)
            {
                ballcontrol.s_Pulse = currentBallSpeed * 2;
            }
            else if(incSize)
            {
                PaddleIncrease();
            }
            else if(decSize)
            {
                PaddleDecrease();
            }

            if(powerLengthcounter == 0)
            {
                ballcontrol.s_Pulse = currentBallSpeed;
                PlayerSize.Paddle = paddleSize;

                powerUpActive = false;
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void activatePowereup(bool Speed, bool sizePlus, bool sizeDown, float time)
    {
        doubleSpeed = Speed;
        incSize = sizePlus;
        decSize = sizeDown;
        powerLengthcounter = time;

        currentBallSpeed = ballcontrol.s_Pulse;
        paddleSize = PlayerSize.Paddle;

        powerUpActive = true;
    }

    void PaddleIncrease()
    {
        GameObject.FindWithTag("Player 1");
        GameObject.FindWithTag("Player 2");
        paddleSize.transform.Translate(0, 4f, 4f);
    }

    void PaddleDecrease()
    {
        GameObject.FindWithTag("Player 1");
        GameObject.FindWithTag("Player 2");
        paddleSize.transform.Translate(0, 1.5f, 1.5f);
    }
}
