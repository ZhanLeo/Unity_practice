using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(NavMeshAgent))]
public class win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 d = target.transform.position - transform.position;
        d.y = 0;
        if (d.magnitude < 1)
        {
            Debug.Log(3);
            SceneManager.LoadScene("fail");
        }
    }
    void OnCollisionEnter(Collision other)
    {
        Debug.Log(2);
        if(other.gameObject == target)
        {
            Debug.Log(3);
            SceneManager.LoadScene("fail");
        }
    }
}
