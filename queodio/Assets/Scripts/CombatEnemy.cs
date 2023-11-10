using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CombatEnemy : MonoBehaviour
{
    [Header ("Atribultes")]
    public float totalHealth;
    public float attackDamage;
    public float movementSpeed;
    public float lookRadius;

    [Header("Components")]
    private Animator anim;
    private CapsuleCollider capsule;
    private NavMeshAgent agent;

    [Header("Others")]
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();
        capsule = GetComponent<CapsuleCollider>();
        agent = GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, transform.position);

        if(distance <= lookRadius)
        {
            //dentro
         
        if(distance <= agent.stoppingDistance)
            {

            }
            
        }
        else
        {
            //fora
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
