﻿using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics 
{
    public class CinematicsTrigger : MonoBehaviour
    {
        bool triggered = false;

        private void OnTriggerEnter(Collider other)
        {
            if (!triggered && other.gameObject.tag == "Player")
            {
                GetComponent<PlayableDirector>().Play();
                triggered = true;
            }
        }
    }
}
