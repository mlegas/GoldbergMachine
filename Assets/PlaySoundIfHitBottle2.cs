using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundIfHitBottle2 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bottle")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
