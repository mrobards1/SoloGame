using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour
{
    public float movementSpeed;
    public float forceJump;
    public Animator animator;

    private Rigidbody2D rigid_body;

    private Vector3 respawnPoint;
    public GameObject deathObject;


    public GameObject loadLevel2;





    void Start()
    {
        rigid_body = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position = transform.position + horizontal * Time.deltaTime * movementSpeed;
        

        if (Input.GetButtonDown("Jump") && Mathf.Abs(rigid_body.velocity.y) < 0.001f)
        {
            rigid_body.AddForce(new Vector2(0, forceJump), ForceMode2D.Impulse);
            animator.SetBool("JumpCheck", true);
        }

        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Respawn")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.tag == "Level2Spawn")
            SceneManager.LoadScene("Level_Two");
    }
}
