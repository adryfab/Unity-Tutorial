using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Script1 s1;

    //Awake se ejecuta antes de Start y sirve para buscar componentes
    private void Awake()
    {
        s1 = Camera.main.GetComponent<Script1>();
        Debug.Log(s1);
        Script2 s2 = gameObject.GetComponentInChildren<Script2>();
        Debug.Log(s2);
        Script3[] s3 = gameObject.GetComponentsInChildren<Script3>();
        Debug.Log(s3.Length);
    }

    private void Start()
    {
        s1.Test();
    }
}
