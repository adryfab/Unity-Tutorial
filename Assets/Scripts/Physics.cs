using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    // Use this for initialization
    public void Shoot ()
    {
        float x = Random.Range(-1f, 1f);
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(x, 0f, 1f) * 100f, ForceMode.Impulse);
    }

}
