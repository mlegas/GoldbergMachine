using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateClockwork : MonoBehaviour
{
	void Update ()
    {
        this.gameObject.transform.Rotate(new Vector3(0, -45, 0) * Time.deltaTime);
    }
}
