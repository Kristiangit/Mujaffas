using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    public float speed;
    [SerializeField] 
    private Renderer bgRenderer; 

    public float distance = 0;
    void Update()
    {
        bgRenderer.material.mainTextureOffset += new Vector2(0, Time.deltaTime * speed);
        distance += Time.deltaTime * speed;
        if (distance > 0.8f) {
            distance = 0f;
        }

        
    }
}