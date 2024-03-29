using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlSpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 5.0f;
    [SerializeField] private GameObject[] girl;

    // Update is called once per frame
    [SerializeField] private float timer = 0f;
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnRate)
        {
            float xpos = Random.Range(2.7f, 3.4f);
            int left = Random.Range(0, 2);

            if (left == 1)
            {
                xpos -= 6.2f;
            }
            int index = Random.Range(0, girl.Length);

            GameManager.Spawn(girl[index], xpos, 5f, Quaternion.identity);
            timer = 0f;
            spawnRate = Random.Range(7f, 20f);
        }

    }
        
    
}
