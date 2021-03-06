using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class teresaAI : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Animator _animator;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float changePositionTime = 5f;
    [SerializeField] private float moveDistance = 1f;
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
        _navMeshAgent.speed = movementSpeed;
        InvokeRepeating(nameof(MoveTeresa), changePositionTime, repeatRate: changePositionTime);
    }

    private void Update()
    {
        _animator.SetFloat(name: "Speed", _navMeshAgent.velocity.magnitude / movementSpeed);
    }
    Vector3 RandomNavSphere (float distance)
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;

        randomDirection += transform.position;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, areaMask:-1); ;

        return navHit.position;
    }

    private void MoveTeresa()
    {
        _navMeshAgent.SetDestination(RandomNavSphere(moveDistance));
    }
    // Update is called once per frame
}
