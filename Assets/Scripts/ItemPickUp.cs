using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public int health = 3;
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
        if (other.CompareTag("Girl"))
        {
            IEnumerator coroute = Wait5();
            StartCoroutine(coroute);
        }
        else if (other.CompareTag("Obstacle"))
        {
            health -= 1;
            Destroy(other.gameObject);
        }
    }

    IEnumerator Wait5()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(5f);
        Time.timeScale = 1f;
    }
}
