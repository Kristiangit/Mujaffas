using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlBehavior : MonoBehaviour
{
    private bool waiting = false;
    void Start()
    {
        gameObject.GetComponent<ItemScroller>().velocity = 1f;
    }
    void Update()
    {
        Debug.Log(gameObject.GetComponent<ItemScroller>().velocity);
        if (transform.position.y < 1f && waiting == false)
        {
            gameObject.GetComponent<GirlAnimation>().enabled = false;
            waiting = true;
        }
    }
        
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("collision");
            gameObject.GetComponent<GirlAnimation>().enabled = true;
        }
    }
}
