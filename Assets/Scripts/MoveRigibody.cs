using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigibody : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.MovePosition(transform.position + Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.MovePosition(transform.position + Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }
    }

    //Se ejecuta antes del Update y después de FixedUpdate
    //private void OnCollisionEnter(Collision collision) //Colisiona una sola vez
    //private void OnCollisionStay(Collision collision) //Colisiona siempre
    //private void OnCollisionExit(Collision collision) //Es cuando una colision deja de existir
    //{
    //    Debug.Log(collision.gameObject.name);
    //}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }
}
