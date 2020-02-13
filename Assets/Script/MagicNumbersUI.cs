using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MagicNumbersUI : MonoBehaviour
{
    public int minNumber = 1;
    public int maxNumber = 1000;
    public int guess;
    int stepNumber = 0;
    public Text guessTxt;
    public TextMeshProUGUI stepNumberTxt;

    void UpdateGuess()
    {
        guess = Random.Range(minNumber, maxNumber+1);
        stepNumber = stepNumber + 1;
        stepNumberTxt.text = stepNumber.ToString();
        guessTxt.text = "" + guess;
    }



    // Start is called before the first frame update
    void Start()
    {
        UpdateGuess();
    }

    // Update is called once per frame
    public void Click(int upOrDown)
    {
        if (upOrDown == 1)
        {
            if (guess == maxNumber-1)
            {
                guess = maxNumber;

            }
            else
            {
                minNumber = guess+1;
                UpdateGuess();
            }
        }

        else if (upOrDown == 0)
        {
            maxNumber = guess-1;
            UpdateGuess();
        }

    }
}
