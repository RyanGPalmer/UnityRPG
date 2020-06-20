using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] private string attackVariable;

        private Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void PrimaryAttack()
        {
            AnimatorStateInfo currentState = animator.GetCurrentAnimatorStateInfo(0);
            if (!currentState.IsName("Attack"))
                animator.SetTrigger(attackVariable);
        }

        // Animation Event
        void Hit()
        {
            Debug.Log("POW!!");
        }
    }
}