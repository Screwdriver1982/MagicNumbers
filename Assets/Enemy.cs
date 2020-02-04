using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Player playerVar;
    // Start is called before the first frame update
    void Start()
    {
        playerVar.playerName = playerVar.playerName + "The Brave";
        Debug.Log("Hello " + playerVar.playerName + "! I'm your enemy!");
    }

    public void RunAway()
    {
        Debug.Log("I'm Scared!");
    }

    void Win()
    { 
    
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Come on " + playerVar.playerName + "! Let's fight!"); 
    }
}
