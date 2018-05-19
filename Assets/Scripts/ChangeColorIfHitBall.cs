using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}