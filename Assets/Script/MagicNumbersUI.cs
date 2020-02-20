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
    public int stepNumber = 0;
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
        // не удаляет объект, к которому привязан
        Debug.Log("Start Script " + gameObject);
        DontDestroyOnLoad(gameObject); // запрещает уничтожать объект при переходе со сцены на сцену
        UpdateGuess();
    }

    void OnDestroy()
    {
        Debug.Log("Destroy script");
    }

    // Update is called once per frame
    public void Click(int upOrDown)
    {
        if (upOrDown == 1)
        {
            if (guess == maxNumber)
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
