using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1.0f;
    [SerializeField] private GameObject[] moneys = {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] private float timer = 0f;
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= spawnRate)
        {
            // Debug.Log("money spawned");
            int index = Random.Range(0, 3);
            float xpos = Random.Range(-3.5f, 3.5f);

            GameManager.Spawn(moneys[index], xpos, 5f, Quaternion.identity);
            timer = 0f;
            spawnRate = Random.Range(0.5f, 2.5f);
        }

    }
        
    
}
