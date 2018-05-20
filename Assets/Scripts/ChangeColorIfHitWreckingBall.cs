using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitWreckingBall : MonoBehaviour
{
    private bool soundPlayed = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BigBall2")
        {
            if (!soundPlayed)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                soundPlayed = true;
            }
            collision.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}