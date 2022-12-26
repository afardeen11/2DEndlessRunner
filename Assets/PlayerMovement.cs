using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator animator;
    public float speed = 5f;
    public int deltaTelepot = 10;
    // Start is called before the first frame update


    public void Jump(InputAction.CallbackContext context){
        Debug.Log("Jump");
        transform.position = new Vector2(transform.position.x, transform.position.y + deltaTelepot);



    }

    public void Dash(InputAction.CallbackContext context){
        Debug.Log("Dash");
        transform.position = new Vector2(transform.position.x + deltaTelepot, transform.position.y);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(speed, rb.velocity.y);
        rb.AddForce(new Vector2(0, -9.81f));
        //rb.acceleration = new Vector2(0, -9.81f);
        animator.SetFloat("yVelocity", rb.velocity.y);
    }
}
