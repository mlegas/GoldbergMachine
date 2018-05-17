using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitRamp : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Release Collider")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
