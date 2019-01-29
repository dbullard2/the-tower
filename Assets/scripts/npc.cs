using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npc : MonoBehaviour
{
    [SerializeField]
    private GameObject house;
    
    private bool hasApartment = false;

    public NavMeshAgent agent;

    void Start() {
        apartmentManager manager = GameObject.Find("apartmentManager").GetComponent<apartmentManager>();
        house = manager.apartments[0];
        agent.SetDestination(house.transform.position);
    }

    // Update is called once per frame
    void Update() {

    }
}
