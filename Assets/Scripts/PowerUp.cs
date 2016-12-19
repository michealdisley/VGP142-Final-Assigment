using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PowerUp : MonoBehaviour // : NetworkBehaviour
{
    public bool doubleSpeed;
    public bool incSize;
    public bool decSize;

    public float powerUpLength;

    private GameManager PowerUpManager;

    void start()
    {
        PowerUpManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.name == "Ball")
        {
            PowerUpManager.activatePowereup(doubleSpeed, incSize, decSize, powerUpLength);
        }
        gameObject.SetActive(false);
    }
 
}
