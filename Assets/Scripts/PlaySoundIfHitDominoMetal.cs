using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitDominoMetal : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Domino")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
