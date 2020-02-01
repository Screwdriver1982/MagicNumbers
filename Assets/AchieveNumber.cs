using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchieveNumber : MonoBehaviour
{
    int needNumber = 50;
    int currentSum = 0;
    int stepNumber = 0;
    string playerName = "Alex";

    void StartGame()
    {

        needNumber = 50;
        currentSum = 0;
        stepNumber = 1;
        Debug.Log("Please enter an integer from 1 to 9.");

    }

    void SumUpdate(int enteredNumber)
    {
        Debug.Log(enteredNumber);
        currentSum = currentSum + enteredNumber;
        if (currentSum >= needNumber)
        {
            Debug.Log("You have achieved " + needNumber + " in " + stepNumber + " steps.");
            StartGame();
        }
        else
        {
            Debug.Log("Current sum is: " + currentSum);
            stepNumber = stepNumber + 1;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Achieve-50 Game, " + playerName + "!");
        StartGame();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            SumUpdate(1);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            SumUpdate(2);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            SumUpdate(3);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            SumUpdate(4);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            SumUpdate(5);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            SumUpdate(6);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7))
        {
            SumUpdate(7);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            SumUpdate(8);
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9))
        {
            SumUpdate(9);
        }
    }
}
