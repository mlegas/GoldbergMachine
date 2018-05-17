using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitHammer : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball Start Holder")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
