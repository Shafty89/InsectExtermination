using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    [SerializeField] float turnSpeed = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    bool isProvoked = false;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (isProvoked) {
            EngagePlayer();
        }
        else if (distanceToTarget <= chaseRange) {
            isProvoked = true;
        }

    }

    public void OnDamageTaken()
    {
        isProvoked = true;
    }


    private void EngagePlayer()
    {
        RotateToPlayer();   //Rotate to player

        if (distanceToTarget >= navMeshAgent.stoppingDistance) {
            ChasePlayer();
        }

        if (distanceToTarget <= navMeshAgent.stoppingDistance) {
            AttackPlayer();
        }
    }

    private void ChasePlayer()
    {
        GetComponent<Animator>().SetBool("attack", false); 
        GetComponent<Animator>().SetTrigger("move");    //Triggers move from animator
        navMeshAgent.SetDestination(target.position);
    }

    private void AttackPlayer()
    {
        GetComponent<Animator>().SetBool("attack", true);    //Triggers attack from animator
    }

    private void RotateToPlayer()   //Allows the enemy to face the player at all times
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
        
    }
}
