/*
 * Source File Name: AmmoScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control behaviour of ammo prefabs
 */

using UnityEngine;
using System.Collections;

public class AmmoScript : MonoBehaviour {

    public int dmg = 2;

    public bool isShot = false;

	void Start () {
        //destroy gameObject, if nothing is destroyed let fly for 1 second.
        Destroy (gameObject, 1);
	}
}
