using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitBallHammer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Hammer")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
