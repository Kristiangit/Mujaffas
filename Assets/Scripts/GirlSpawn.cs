using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlSpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 10.0f;
    [SerializeField] private GameObject girl;

    // Update is called once per frame
    [SerializeField] private float timer = 0f;
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnRate)
        {
            float xpos = Random.Range(2.6f, 3.5f);
            int left = Random.Range(0, 2);

            if (left == 1)
            {
                xpos -= 5.2f;
            }


            GameManager.Spawn(girl, xpos, 5f, Quaternion.identity);
            timer = 0f;
            spawnRate = Random.Range(10f, 20f);
        }

    }
        
    
}
