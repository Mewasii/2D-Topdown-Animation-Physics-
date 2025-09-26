using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    private Cat playerControls;
    private Vector3 moveInput;
    private Rigidbody2D rb;
    public Animator animator;
    public float SpeedBoost = 4f;
    bool jump = false;
    private float jumpTime;
    public float jumpT;
    bool run = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        Move();
        Jump();
        Run();

    }
    private void Move()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;
        animator.SetFloat("Speed", moveInput.sqrMagnitude);

        if (moveInput.x != 0)
        {
            if (moveInput.x > 0)
            {
                transform.localScale = new Vector3(5, 5, 0);
            }
            else
            {
                transform.localScale = new Vector3(-5, 5, 0);
            }
        }
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpTime <= 0)
        {
            animator.SetBool("Jump", true);
            moveSpeed += SpeedBoost;
            jumpTime = jumpT;
            jump = true;
        }
        if (jumpTime <= 0 && jump == true)
        {
            animator.SetBool("Jump", false);
            moveSpeed -= SpeedBoost;
            jump = false;
        }
        else
        {
            jumpTime -= Time.deltaTime;
        }
    }
    private void Run()
    {
        if (Input.GetKey(KeyCode.LeftControl) && run == false)
        {
            moveSpeed += SpeedBoost;
            animator.SetBool("Running", true);
            run = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            moveSpeed -= SpeedBoost;
            animator.SetBool("Running", false);
            run = false;

        }

    }


}
