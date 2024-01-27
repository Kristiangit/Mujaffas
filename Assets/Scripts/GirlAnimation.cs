using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAnimation : MonoBehaviour
{
    [SerializeField] private float timer = 0f;
    // Update is called once per frame
    private bool walk = false;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 20f / 60f)
        {
            GameObject Frame1 = gameObject.transform.GetChild(0).gameObject;
            GameObject Frame2 = gameObject.transform.GetChild(1).gameObject;

            if (walk)
            {
                Frame1.SetActive(true);
                Frame2.SetActive(false);
                walk = false;
            }
            else
            {
                Frame1.SetActive(false);
                Frame2.SetActive(true);
                walk = true;
            }
            timer = 0f;
        }
    }
}
