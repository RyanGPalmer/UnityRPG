using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] private string attackVariable;
        [SerializeField] private float attackDelay;

        private Animator animator;
        private float timeSinceLastAttack;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        void Update()
        {
            timeSinceLastAttack += Time.deltaTime;
        }

        public void PrimaryAttack()
        {
            if (timeSinceLastAttack >= attackDelay && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                animator.SetTrigger(attackVariable);
                timeSinceLastAttack = 0;
            }
        }

        // Animation Event
        void Hit()
        {
            Debug.Log("POW!!");
        }
    }
}