using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CharacterController : MonoBehaviour
{
    public float movementSpeed;
    public float forceJump;
    public Animator animator;
    
    float inputHorizontal;

    

    private Rigidbody2D rigid_body;

    private Vector3 respawnPoint;
    public GameObject deathObject;

    public GameObject loadLevel2;

    public DeathMenu deathMenu;



    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        respawnPoint = transform.position;
        

    }

    // Update is called once per frame
    void Update()
    {
        
        

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigid_body.velocity.y) < 0.001f)
        {
            rigid_body.AddForce(new Vector2(0, forceJump), ForceMode2D.Impulse);
            animator.SetBool("JumpCheck", true);
        } else
        {
            animator.SetBool("JumpCheck", false);
        }


        float moveInput = Input.GetAxisRaw("Horizontal");
        rigid_body.velocity = new Vector2(moveInput * movementSpeed, rigid_body.velocity.y);

        if (moveInput == 0)
        {
            animator.SetBool("isWalking", false);
        } else
        {
            animator.SetBool("isWalking", true);
        }

        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            deathMenu.toggleDeathMenu();
        }

        if (collision.tag == "Level2Spawn")
            SceneManager.LoadScene("Level_Two");
    }


}
