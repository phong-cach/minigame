using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHigh = 10f;
    public Rigidbody2D rb;
    public Boolean isGrounded;
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Khi nhân vật chạm đất, cho phép nhảy lại
        }
    }
    // Update is called once per frame
    void Update()
    {

        float move = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(-move, 0, 0);

        myAnimator.SetBool("isRunning", false);
        if (move != 0)
        {
            myAnimator.SetBool("isRunning", true);
        }
        else
        {
            rb.velocity = new Vector2(move, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpHigh, ForceMode2D.Impulse);
            isGrounded = false;
        }



    }


}


