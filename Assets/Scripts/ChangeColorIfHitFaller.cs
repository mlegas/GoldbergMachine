using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitFaller : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Faller")
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
