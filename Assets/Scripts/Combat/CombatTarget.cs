using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatTarget : MonoBehaviour
{
    public void ReceiveHit()
    {
        Debug.Log(gameObject.name + " got hit!!");
    }
}
