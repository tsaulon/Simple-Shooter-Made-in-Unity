/*
 * Source File Name: movementScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control behaviour of movement in all prefabs
 */

using UnityEngine;
using System.Collections;

public class movementScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);

    public Vector2 spDirection = new Vector2(-1, 0);

	// Update is called once per frame
	void Update () {

        Vector3 direction = new Vector3(speed.x * spDirection.x, speed.y * spDirection.y, 0);

        //smooth out movement on screen.
        direction *= Time.deltaTime;

        transform.Translate(direction);
	}
}
