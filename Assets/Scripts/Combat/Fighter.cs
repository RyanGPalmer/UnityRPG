using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Core;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] LayerMask hitLayer;
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
            foreach (CombatTarget target in GetHits())
                target.ReceiveHit();
        }

        private List<CombatTarget> GetHits()
        {
            Vector3 bottom = transform.position + transform.forward - Vector3.up * 2;
            Vector3 top = transform.position + transform.forward + Vector3.up * 3;
            DrawDebugCapsule(bottom, top, 1);
            Collider[] hits = Physics.OverlapCapsule(bottom, top, 1, hitLayer.value);

            List<CombatTarget> combatTargetHits = new List<CombatTarget>();
            foreach (Collider collider in hits)
            {
                CombatTarget combatTarget;
                if (collider.TryGetComponent<CombatTarget>(out combatTarget))
                    combatTargetHits.Add(combatTarget);
            }

            return combatTargetHits;
        }

        private void DrawDebugCapsule(Vector3 bottom, Vector3 top, float radius)
        {
            DebugExtension.DebugCapsule(bottom, top, Color.red, radius, 1);
        }
    }
}