/*
 * Source File Name: WeaponScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control weapon triggers to launch ammo.
 */

using UnityEngine;
using System.Collections;

public class WeaponScript : MonoBehaviour {


  public Transform shotPrefab;

  public float shootingRate = 0.25f;


  private float shootCD;

  void Start()
  {
    shootCD = 0f;
  }
    //check for shooting availability;
  void Update()
  {
    if (shootCD > 0)
    {
      shootCD -= Time.deltaTime;
    }
  }
    //check and create if weapon is available
  public void Attack(bool isEnemy)
  {
    if (CanAttack)
    {
      shootCD = shootingRate;

      //create shot
      var shotTransform = Instantiate(shotPrefab) as Transform;

      //positioning
      shotTransform.position = transform.position;

      //check if enemy
      AmmoScript shot = shotTransform.gameObject.GetComponent<AmmoScript>();
      if (shot != null)
      {
        shot.isShot = isEnemy;
      }

      //shoot at enemy
      movementScript move = shotTransform.gameObject.GetComponent<movementScript>();
      if (move != null)
      {
        move.spDirection = this.transform.right;
      }
    }
  }

    //check if weapon/ammo is off cd
  public bool CanAttack
  {
    get
    {
      return shootCD <= 0f;
    }
  }
}
