﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitSwitch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}