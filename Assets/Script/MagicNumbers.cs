using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    int minNumber = 1;
    int maxNumber = 1000;
    string playerName = "Alex";
    int guess;
    int stepNumber = 0;

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
        stepNumber = 0;
        Debug.Log("Please, choose your number");
        Debug.Log("Min number: " + minNumber);
        Debug.Log("Max number: " + maxNumber);
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is Your number : " + guess + " ? ");
        stepNumber = stepNumber + 1;
    }

    void EndGame()
    {
        Debug.Log("I have found! Your number is: " + guess);
        Debug.Log("Step number is: " + stepNumber);
        StartGame();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (guess == 999)
            {
               guess = 1000;
               EndGame();

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
            EndGame();
        }
    }
}
