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
        if (other.CompareTag("Girl"))
        {
            Debug.Log("girl");
            IEnumerator coroute = Wait5();
            StartCoroutine(coroute);
            // Debug.Log("restart");

        }
        else if (other.gameObject.tag != "Untagged")
        {
            Destroy(other.gameObject);
        }
    }
    void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.tag);
    }

    IEnumerator Wait5()
    {
        Time.timeScale = 0f;
        yield return new WaitForSecondsRealtime(5f);
        // Debug.Log("rerestart 5");
        Time.timeScale = 1f;
    }
}
