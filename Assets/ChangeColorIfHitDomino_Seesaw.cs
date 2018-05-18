using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitDomino_Seesaw : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Domino")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}
