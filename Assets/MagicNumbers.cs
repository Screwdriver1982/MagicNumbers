using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 1000;
    string playerName = "Alex";
    int guess;

    //Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to our game, " + playerName);
        Debug.Log("Please, choose your number");
        Debug.Log("Min number: " + minNumber);
        Debug.Log("Max number: " + maxNumber);

        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is Your number : " + guess + " ? ");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            guess = (maxNumber + minNumber) / 2;
            Debug.Log("Is your number: " + guess + " ? ");
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            guess = (maxNumber + minNumber) / 2;
            Debug.Log("Is your number: " + guess + " ? ");
        }

        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("I have found! Your number is: " + guess);
        }
    }
}
