using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Ball : MonoBehaviour // : NetworkBehaviour
{
    // Public
    public static float ballSpeed = 20;
    public Vector3 s_Pulse;

    private Rigidbody s_rb;

	// Use this for initialization
	void Start ()
    {
        // ballSpeed = new Vector3(1, 20, 0);
        s_rb = GetComponent<Rigidbody>();
        if (!s_rb) { Debug.Log("RigidBody on ball not found."); }

        s_rb.AddForce(s_Pulse, ForceMode.Impulse);
	}
	
}
