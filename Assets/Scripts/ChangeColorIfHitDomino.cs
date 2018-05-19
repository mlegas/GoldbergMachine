﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorIfHitDomino : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Domino")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}