using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
