using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int money = 0;
    private bool isMoney = false;
    private int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Money100"))
        {
            Debug.Log("Picked up 100");
            value = 100;
            isMoney = true;
        }
        else if (other.CompareTag("Money200"))
        {
            Debug.Log("Picked up 200");
            value = 200;
            isMoney = true;
        }
        else if (other.CompareTag("Money500"))
        {
            Debug.Log("Picked up 500");
            value = 500;
            isMoney = true;
        }

        if (isMoney)
        {
            money = money + value;
            Destroy(other.gameObject);
            isMoney = false;

        }
    }
}
