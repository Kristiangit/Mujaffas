using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySpawn : MonoBehaviour
{
    [SerializeField] private float spawnRate = 1.0f;
    [SerializeField] private GameObject[] moneys = {};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float timer = 0;
        timer = timer + Time.deltaTime;
        if (timer >= spawnRate)
        {
            int index = Random.Range(0, 3);
            float xpos = Random.Range(-3.5f, 3.5f);

            Spawn(moneys[index], xpos, 1.9f);
            timer = 0f;
        }
    }
        
    void Spawn(GameObject prefab, float xpos, float ypos)
    {
        Instantiate(prefab, new Vector3(xpos, ypos, 0f), Quaternion.identity);
    }
}
