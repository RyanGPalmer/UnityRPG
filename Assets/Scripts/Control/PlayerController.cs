using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using RPG.Movement;
using RPG.Core;
using RPG.Combat;

namespace RPG.Control
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] Transform movementOrientationTransform;

        private Mover mover;
        private Fighter fighter;
        private Vector2 direction;

        void Start()
        {
            mover = GetComponent<Mover>();
            fighter = GetComponent<Fighter>();
        }

        void Update()
        {
            mover.MoveTo(GetMoveTarget());
        }

        // Input Event
        void OnMove(InputValue value)
        {
            direction = value.Get<Vector2>();
        }

        // Input Event
        void OnPrimaryAttack()
        {
            fighter.PrimaryAttack();
        }

        private Vector3 GetMoveTarget()
        {
            Vector3 forward = movementOrientationTransform.forward * direction.y;
            Vector3 right = movementOrientationTransform.right * direction.x;
            Vector3 moveVector = new Vector3(forward.x + right.x, 0, forward.z + right.z);

            return transform.position + moveVector;
        }
    }
}