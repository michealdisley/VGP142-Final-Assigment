using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public enum s_Player { Player1, Player2, }

public class Player : MonoBehaviour //: NetworkBehaviour
{
    public GameObject Paddle;

    private float s_Speed = 10.0f;
    private s_Player player;

    private Rigidbody s_rb;

	// Use this for initialization
	void Start ()
    {
        s_rb = GetComponent<Rigidbody>();
        if (!s_rb) { Debug.Log("RigidBody on ball not found."); }
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float inputSpeed = 20f;

        if (player == s_Player.Player1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                s_rb.velocity = new Vector3(0f, inputSpeed, 0f) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                s_rb.velocity = new Vector3(0f, -inputSpeed, 0f) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                s_rb.velocity = new Vector3(0f, 0f, -inputSpeed) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                s_rb.velocity = new Vector3(0f, 0f, inputSpeed) * s_Speed * Time.deltaTime;
            }
            else
                s_rb.velocity = new Vector3(0f, 0f, 0f);
        }
        else if (player == s_Player.Player2)
        {
            if (Input.GetKey(KeyCode.W))
            {
                s_rb.velocity = new Vector3(0f, inputSpeed, 0f) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                s_rb.velocity = new Vector3(0f, -inputSpeed, 0f) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                s_rb.velocity = new Vector3(0f, 0f, -inputSpeed) * s_Speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                s_rb.velocity = new Vector3(0f, 0f, inputSpeed) * s_Speed * Time.deltaTime;
            }
        }

       // transform.position += new Vector3(0, inputSpeed, inputSpeed * s_Speed * Time.deltaTime);
	}


}
