using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public int health;
    public int money;
    [SerializeField] private GameObject player;
    [SerializeField] private Text m_text;
        
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

        m_text.text = moneys;
        // gameObject.transform.GetChild(3).GetChild(1).GetChild(0).gameObject.GetComponent<UnityEngine.UI.Text>().text = moneys;
    }
}
