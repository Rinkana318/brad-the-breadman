using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadDestroyer : MonoBehaviour
{
    public GameObject Player;

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            Destroy(gameObject);
        }
    }

}
