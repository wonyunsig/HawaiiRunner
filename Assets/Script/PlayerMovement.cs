using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed;
    public float jumpPower;
    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;
    private Animator anim;
    private Collision collision;
    private bool canInteract = true; // 입력 기능 활성화 여부
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        //Jump
       // if (Input.GetButton("Jump") && !anim.GetBool("isJumping")) 
        {
            //rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            //anim.SetBool("isJumping", true);
        }

        //Stop Speed
        
            if (Input.GetButtonUp("Horizontal"))
            {
                rigid.velocity = new Vector2(rigid.velocity.normalized.x*0.5f, rigid.velocity.y);
            }
        
    //if (Input.GetButtonUp("Horizontal"))
       // {
           // rigid.velocity = new Vector2(rigid.velocity.normalized.x*0.5f, rigid.velocity.y);
       // }

        //Direction Sprite
        
        
            if (Input.GetButtonDown("Horizontal"))
                spriteRenderer.flipX = Input.GetAxisRaw("Horizontal") == -1;
        

        //Animation
        if(Mathf.Abs(rigid.velocity.x) < 0.3)
            anim.SetBool("isWalking", false);
        else
            anim.SetBool("isWalking", true);
    }

    private void FixedUpdate()
    {
        //Move Speed
        if (canInteract)
        {
            float h = Input.GetAxisRaw("Horizontal");
            rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);
            if (Input.GetButton("Jump") && !anim.GetBool("isJumping")) 
            {
                rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
                anim.SetBool("isJumping", true);
            }
        }

        //Max Speed
        if (rigid.velocity.x > maxSpeed)
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        else if (rigid.velocity.x < maxSpeed * (-1))
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        
        //Landing Platform
        if (rigid.velocity.y < 0)
        {
            Debug.DrawRay(rigid.position, Vector3.down, new Color(0, 1, 0));

            RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, Vector3.down, 1, LayerMask.GetMask("Platform"));

            if (rayHit.collider != null)
            {
                if(rayHit.distance < 1f)
                    anim.SetBool("isJumping",false);
            }

        }
    }public float launchForce = 10f; // 날리는 힘의 세기
    public Vector2 launchDirection = new Vector2(-1f, 1f); // 날리는 방향 (왼쪽 위)


    private void LaunchObject()
    {
        rigid.AddForce(launchDirection.normalized * launchForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
            canInteract = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Spike") )
        {
            canInteract = false; // 입력 기능 비활성화
            launchForce = 20f;
            LaunchObject();
        }
    }
}
