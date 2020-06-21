using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTarget : MonoBehaviour
{
    [SerializeField] float maxHealth;
    [SerializeField] string hitVariable;
    [SerializeField] string dieVariable;

    private Animator animator;
    private float health;
    private bool isDead;

    void Start()
    {
        animator = GetComponent<Animator>();
        health = maxHealth;
        isDead = false;
    }

    public void ReceiveHit(float damage)
    {
        if (isDead) return;

        health -= damage;
        if (health <= 0)
        {
            isDead = true;
            animator.SetTrigger(dieVariable);
            Debug.Log(gameObject.name + " died!");
        }
        else
        {
            animator.SetTrigger(hitVariable);
            Debug.Log(gameObject.name + " has " + health + " health remaining!");
        }
    }
}
