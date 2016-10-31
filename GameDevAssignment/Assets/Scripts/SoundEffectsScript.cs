/*
 * Source File Name: SoundEffectsScript.cs
 * Author: Tyrone Saulon 100824599
 * Date: October 30, 2016.
 * Description: Script used to control behaviour of sound effects.
 */

using UnityEngine;
using System.Collections;

public class SoundEffectsScript : MonoBehaviour
{


        /// <summary>
        /// Singleton
        /// </summary>
        public static SoundEffectsScript Instance;

        public AudioClip explosionSound;

        void Awake()
        {
            // create singleton
            if (Instance != null)
            {
                Debug.LogError("Multiple instances of SoundEffectsHelper!");
            }
            Instance = this;
        }
        
        //create sound
        public void MakeExplosionSound()
        {
            MakeSound(explosionSound);
        }
        
        //activate sound on event.
        private void MakeSound(AudioClip originalClip)
        {
            AudioSource.PlayClipAtPoint(originalClip, transform.position);
        }
}

