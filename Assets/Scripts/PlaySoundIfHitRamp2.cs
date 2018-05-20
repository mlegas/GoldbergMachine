using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitRamp2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball2")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
