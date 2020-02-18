using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScreen : MonoBehaviour
{
    public Text resultText;

    // Start is called before the first frame update
    void Start()
    {
       
        /*
        Debug.Log("Before for");


        int[] numbers = { 0, 5, 67, 85 };

        for (int i = 0; i < numbers.Length; i++) //проходится по всем элементам массива
        {
            //содержимое выполняется только если выполнено условие цикла, в конце выполнения содержимого цикла счетчик увеличивается на 1
            Debug.Log("number" + i + " :" + numbers[i]);

        }
        Debug.Log("After for");
        */
        Text[] allTexts = FindObjectsOfType<Text>(); //ищет все компоненты типа Текст
        for (int i = 0; i < allTexts.Length; i++)
        {
            allTexts[i].text = "Text" + i;
        }



        MagicNumbersUI magicNumbers = FindObjectOfType<MagicNumbersUI>(); //ищет первую попавшуюся компоненту с таким типом, сама компонента привязана к какому-то объекту
        int number = magicNumbers.guess;
        int step = magicNumbers.stepNumber;
        resultText.text = "Ваше число " + number;

        Destroy(magicNumbers.gameObject); //уничтожает объект, к которому привязана найденная компонента
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
