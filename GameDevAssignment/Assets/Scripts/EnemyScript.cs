/*
 * Source File Name: EnemyScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control behaviour of enemy prefabs
 */

using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    private WeaponScript weapon;

    //call weapon
    void Awake()
    {
        weapon = GetComponent<WeaponScript>();
    }
    
    //check if weapon is off cooldown and can attack
    void Update()
    {
        if (weapon != null && weapon.CanAttack)
        {
            weapon.Attack(true);
        }
    }
}
