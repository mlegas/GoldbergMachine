using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitRamp2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ramp")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}