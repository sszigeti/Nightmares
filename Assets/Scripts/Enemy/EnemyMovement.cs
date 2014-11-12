using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;
    //PlayerHealth playerHealth;
    //EnemyHealth enemyHealth;
    NavMeshAgent nav;

    void Awake ()
    {
        //player = GameObject.FindGameObjectWithTag ("Player").transform;// For some reason with this the Transform will not get updated, it will be stuck at 0,0,0
		player = GameObject.Find ("Player").transform;// This is needed for the Transform to be dynamic as expected
        //playerHealth = player.GetComponent <PlayerHealth> ();
        //enemyHealth = GetComponent <EnemyHealth> ();
        nav = GetComponent <NavMeshAgent> ();
    }

    void Update ()
    {
		Debug.Log (player.position);
        //if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        //{
            nav.SetDestination (player.position);
        //}
        //else
        //{
        //    nav.enabled = false;
        //}
    }
}
