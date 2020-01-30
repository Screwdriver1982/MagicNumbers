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
        StartGame();
    }

    void StartGame()
    {
        minNumber = 1;
        maxNumber = 1000;
        Debug.Log("Please, choose your number");
        Debug.Log("Min number: " + minNumber);
        Debug.Log("Max number: " + maxNumber);
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is Your number : " + guess + " ? ");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (guess == 999)
            {
               guess = 1000;
               Debug.Log("I have found! Your number is: " + guess);
               StartGame();
            }
            else
            {
                minNumber = guess;
                UpdateGuess();
            } 
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            UpdateGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("I have found! Your number is: " + guess);
            StartGame();
        }
    }
}
