using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navScript : MonoBehaviour {

    public GameObject target;
    public string playerTag = "Player";

    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {

        target = null;
		
	}
	
	// Update is called once per frame
	void Update () {

        if(target != null)
        {
            agent.destination = target.transform.position;
        }
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == playerTag)
        {
            target = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == playerTag)
        {
            if(target == other.gameObject)
            {
                target = null;
            }
        }
    }
}
