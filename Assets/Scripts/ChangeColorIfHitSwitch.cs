using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitSwitch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Switch")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}

