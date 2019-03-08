using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class breadCollector : MonoBehaviour
{
    public Text textbox;
    public float bread = 0f;

    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        textbox.text = "" + bread;

        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Bread")
        {
            bread = bread + 1;
            audioSource.Play();
        }
    }
}
