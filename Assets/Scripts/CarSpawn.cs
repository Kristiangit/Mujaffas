using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 3.0f;
    [SerializeField] private GameObject car;

    // Update is called once per frame
    [SerializeField] private float timer = 0f;
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnRate)
        {
            float xpos = Random.Range(-1.4f, 0f);

            GameManager.Spawn(car, xpos, 5f, Quaternion.identity);
            timer = 0f;
            spawnRate = Random.Range(4f, 7f);
        }

    }
        
    
}
