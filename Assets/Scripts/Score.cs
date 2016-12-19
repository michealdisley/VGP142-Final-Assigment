using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public int scorePlayer1;
    public int scorePlayer2;
    public GUIStyle style;
    
    void OnGUI()
    {
        float x = Screen.width/2f;
        float y = 20f;
        float Height = 300f;
        float Width = 20f;
        string text = "Player 1:" + scorePlayer1 + "            " + "Player 2:" + scorePlayer2;

        GUI.Label(new Rect(x - (Width / 2f), y, Width, Height), text, style);
    }
}
