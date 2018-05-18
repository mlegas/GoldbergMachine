using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitBowl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bowl")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
