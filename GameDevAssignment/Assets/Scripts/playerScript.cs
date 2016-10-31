/*
 * Source File Name: playerScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to demonstrate player controls
 */

using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

    public Vector2 speed = new Vector2(50, 50);

	// Update is called once per frame
	void Update () {
	    float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(speed.x * movementX, speed.y * movementY, 0);

        //smooth out movement on screen.
        direction *= Time.deltaTime;

        transform.Translate (direction);

        //use weapon

        bool shoot = Input.GetButtonDown("Fire1");
        shoot |= Input.GetButtonDown("Fire2");

        //if shoot = true; 
        if (shoot)
        {   //call WeaponScript as weapon
            WeaponScript weapon = GetComponent<WeaponScript>();
            //if weapon can't attack
            if(weapon != null)
            {
                //don't attack
                weapon.Attack(false);
            }
        }
	}
}
