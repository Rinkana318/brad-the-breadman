using UnityEngine;
using UnityEngine.UI;

public class spike : MonoBehaviour
{

    public GameObject player;
    public Text textbox;
    public float health = 3f;
    public float damage = 1f;
    public GameObject Death;

    private void Update()
    {
        textbox.text = "X" + health;

        if (health <= 0)
        {
            death();
            Destroy(gameObject);
        }
    }

    void death()
    {
        Death.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Spike")
        {
            Reset();
        }
    }
    
    private void Reset()
    {
        transform.position = GameObject.FindWithTag("Respawn").transform.position;
        health = health - damage;
        
    }

}
