using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    
    public Rigidbody2D rb;
    public Animator animator;
    private Vector3 velocity = Vector3.zero;
    public SpriteRenderer spriteRenderer;
    //public float JumpForce = 100;
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis ("Horizontal") * moveSpeed * Time.deltaTime;
        MovePlayer(horizontalMovement);

        Flip(rb.velocity.x);
        float characterVelocity = Mathf.Abs(rb.velocity.x); //renvoyer toujours une valeur positive de la vitesse
        animator.SetFloat("speed", characterVelocity);

        if (Input.GetKey(KeyCode.J) && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce( new Vector2 (0, 24), ForceMode2D.Impulse);
        }
    
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }

    void Flip (float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
    

}
