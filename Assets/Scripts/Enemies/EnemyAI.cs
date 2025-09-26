using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float chaseRange = 10f;
    public float attackRange = 2f;

    private Transform playerTransform;
    private Rigidbody2D rb;
    private Animator animator;
 
    
    

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        // Tính khoảng cách từ enemy đến player
        float distance = Vector2.Distance(transform.position, playerTransform.position);

        // Nếu player ở trong tầm nhìn của enemy
        if (distance <= chaseRange)
        {
            // Theo đuổi player
            ChasePlayer();
            

            // Nếu player ở trong tầm tấn công
            if (distance <= attackRange)
            {
        
            }
        }
        else
        {
            // Dừng di chuyển
            StopMoving();
            
        }
    }

    private void ChasePlayer()
    {
        // Di chuyển đến vị trí của player
        Vector2 direction = (playerTransform.position - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
        animator.SetBool("Run", true);
        animator.SetFloat("x", direction.x);
    



        // Xoay enemy về hướng của player



    }

    private void StopMoving()
    {
        // Dừng di chuyển
        rb.velocity = Vector2.zero;
        animator.SetBool("Run", false);


    }
}
