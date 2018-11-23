using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Targeting : MonoBehaviour {

    public GameObject target;
	void Start () {
		
	}
	
	void Update () {
        GetComponent<NavMeshAgent>().destination = target.transform.position;
	}
}
