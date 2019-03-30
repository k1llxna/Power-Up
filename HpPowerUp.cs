using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPowerUp : MonoBehaviour {

    public GameObject effect;

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Player stats = col.GetComponent<Player>();
            stats.hp = 6;

            Instantiate(effect, stats.transform.position, stats.transform.rotation);
            Destroy(gameObject);
            Debug.Log("HP Restored!");
        }
    }
}


