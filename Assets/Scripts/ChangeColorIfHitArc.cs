using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitArc : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arc")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
