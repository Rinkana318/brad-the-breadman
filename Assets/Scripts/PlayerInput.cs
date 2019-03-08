using UnityEngine;

[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player player;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    private void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        player.SetDirectionalInput(directionalInput);

        if (Input.GetButtonDown("Jump"))
        {
            player.OnJumpInputDown();
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonUp("Jump"))
        {
            player.OnJumpInputUp();
        }
        if (Input.GetButton("Horizontal"))
        {
            animator.SetFloat("Speed", 1);
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            spriteRenderer.flipX = true;
        }
    }
}
