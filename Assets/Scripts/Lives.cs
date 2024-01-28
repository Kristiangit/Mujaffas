using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int health;
    public int money;
    [SerializeField] private GameObject player;
        
    void Update()
    {
        health = player.GetComponent<ItemPickUp>().health;
        string moneys = player.GetComponent<ItemPickUp>().money.ToString();

        for (int i = 0; i < 3; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        for (int i = 0; i < health; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }

        gameObject.transform.GetChild(3).GetChild(1).gameObject.GetComponent<TextMesh>().text = moneys;
    }
}
