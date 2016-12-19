using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Effects : MonoBehaviour
{
    public float s_Length;
    public UnityAction s_Action;
    public UnityAction s_EndAction;

    public Effects(float s_Length, UnityAction s_Action, UnityAction s_EndAction)
    {
        this.s_Length = s_Length;
        this.s_Action = s_Action;
        this.s_EndAction = s_EndAction;
    }



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
