using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScroller : MonoBehaviour
{
    public float velocity = GameManager.velocity;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y -= velocity * Time.deltaTime;
        
        transform.position = pos;

        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
}
