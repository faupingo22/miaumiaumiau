using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemai : MonoBehaviour
{
    public float fastfastfast;
    public Transform player;
    private NavMeshAgent agente;

    public void Start()
    {
        agente = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    public void Update()
    {
        agente.SetDestination(player.position);
    }
}
