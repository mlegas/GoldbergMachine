using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitSlider : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slider")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
