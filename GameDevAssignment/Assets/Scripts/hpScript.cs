/*
 * Source File Name: hpScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control behaviour of hp relative to taking damage from Ammo.
 */


using UnityEngine;
using System.Collections;

public class hpScript : MonoBehaviour {
   
    //amount of hp
    public int hp = 2;

    //check if enemy
    public bool isEnemy = true;

    void OnTriggerEnter2D(Collider2D collider)
    {
        //call AmmoScript.cs
        AmmoScript shot = collider.gameObject.GetComponent<AmmoScript>();

        //check if shot
        if (shot != null)
        {   //check if enemy
            if (shot.isShot != isEnemy)
            {   //reduce hp
                hp -= shot.dmg;
                //destroy ammo after use
                Destroy(shot.gameObject);
                //If hp is less than or equal to 0 destroy self gameObject and create sound.
                if (hp <= 0)
                {
                    SoundEffectsScript.Instance.MakeExplosionSound();
                    Destroy(gameObject);
                }
            }
        }
    }
}
