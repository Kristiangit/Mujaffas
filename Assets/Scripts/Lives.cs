using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int health;
    [SerializeField] private GameObject player;
        
    void Update()
    {
        health = player.GetComponent<ItemPickUp>().health;
        for (int i = 0; i < 3; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < health; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }
    }
}
