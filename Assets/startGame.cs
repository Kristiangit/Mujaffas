using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public string MoveScene; 

    void Start()
    {
        MoveScene = "MoveScene";
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene(MoveScene);
        }
    }
}