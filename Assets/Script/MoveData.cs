using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveData: MonoBehaviour
{
    public Text displayName;
    public Text displayLive;

    
    public void Start()
    {
        displayName.text = "Name: " + Display.theName;

        displayLive.text = "Lives: " + Display.lastPlayLive.ToString();

    }
}
