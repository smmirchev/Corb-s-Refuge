using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    NavMeshAgent navmesh;
    public Transform targetPlayer;
    float dangerRadius = 8f;

    Animator animator;

    bool enemyAttacking = false;

    EnemyStats enemyStats;

    // Start is called before the first frame update
    void Start()
    {
        navmesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        enemyStats = GetComponent<EnemyStats>();

    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, targetPlayer.position);

        //Debug.Log(distance);

        //Movement
        if(distance <= dangerRadius)
        {

            transform.LookAt(targetPlayer);
            animator.SetBool("nearby", true);
            navmesh.SetDestination(targetPlayer.position);
        }

        //Attack
        if(distance >= dangerRadius)
        {
            animator.SetBool("nearby", false);
        }
        if(distance <= navmesh.stoppingDistance)
        {
            animator.SetBool("attackRange", true);
            enemyAttacking = true;
        }
        else
        {
            animator.SetBool("attackRange", false);
            enemyAttacking = false;
        }

        if(enemyStats.HP <= 0)
        {
            animator.SetBool("dead", true);
        }
    }

    public bool getEnemyAttacking()
    {
        return enemyAttacking;
    }
}
