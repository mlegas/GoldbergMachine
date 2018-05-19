using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitWreckingBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BigBall")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}