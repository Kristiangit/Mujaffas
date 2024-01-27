using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScroller : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.y -= velocity * Time.deltaTime;
        
        transform.position = pos;
    }
}
