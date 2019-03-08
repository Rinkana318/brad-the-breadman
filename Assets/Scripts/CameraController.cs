using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;

    void LateUpdate()
    {
        transform.position = new Vector3(0, Player.transform.position.y, -10);

        if (Player.transform.position.x >= 0)
        {
            follow();
        }
    }

    void follow()
    {
        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, -10);
    }
}
