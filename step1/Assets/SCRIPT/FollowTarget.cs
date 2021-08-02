using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(NavMeshAgent))]

public class FollowTarget : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent navAgent;
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        //navAgent.SetDestination(target.transform.position);
    }

    void Update()
    {
        navAgent.SetDestination(target.transform.position);
        Vector3 d = target.transform.position - transform.position;
        d.y = 0;
        if (d.magnitude<1)
        {
            Debug.Log(3);
            SceneManager.LoadScene("fail");
        }
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(2);
        if(collision.gameObject == target)
        {
            Debug.Log(3);
            SceneManager.LoadScene("fail");
        }
    }*/
}
