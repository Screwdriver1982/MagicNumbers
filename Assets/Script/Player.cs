using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public Enemy enemyVar;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello! My name is" + playerName); 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Oh no!");
    }
}
