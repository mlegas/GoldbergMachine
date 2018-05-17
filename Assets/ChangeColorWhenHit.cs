using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorWhenHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Holder")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
