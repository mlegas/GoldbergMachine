using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitArc : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Arc")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
