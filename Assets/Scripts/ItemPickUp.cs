using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int money = 0;
    private int value = 0;
        
    void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag.Contains("Money"))
        {
            value = int.Parse(other.gameObject.tag.Remove(0, 5));
            money = money + value;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag != "Untagged")
        {
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);
    }
}
