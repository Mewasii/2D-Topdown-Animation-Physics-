using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemymove : MonoBehaviour
{
    private float EnemyHeath;
    [SerializeField] float MaxEnemyHeath;
    [SerializeField] float hit;
    [SerializeField] HeathBar HeathBar;
   


    private void Start()
    {
        HeathBar = GetComponentInChildren<HeathBar>();
        EnemyHeath = MaxEnemyHeath;
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("fromplayer"))
        {
            EnemyHeath -= hit;
            HeathBar.UpdateHealthBar(EnemyHeath,MaxEnemyHeath);
           if(EnemyHeath <= 0)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        Destroy(this.gameObject);
    }
}
