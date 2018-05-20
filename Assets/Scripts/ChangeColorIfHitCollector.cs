using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitCollector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collector")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
    }
}
