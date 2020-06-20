using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private string animatorSpeedVariable;

        private NavMeshAgent navMeshAgent;
        private Animator animator;

        void Start()
        {
            navMeshAgent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            animator.SetFloat(animatorSpeedVariable, navMeshAgent.velocity.magnitude);
        }

        public void moveTo(Vector3 target)
        {
            //navMeshAgent.SetDestination(target);
            Vector3 origin = transform.position + Vector3.up;
            Vector3 destination = target + Vector3.up;
            Vector3 direction = destination - origin;
            Debug.DrawRay(origin, direction * 100);
            navMeshAgent.SetDestination(target);
        }
    }
}