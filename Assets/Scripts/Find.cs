using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour
{
    private void Awake()
    {
        //GameObject camera = Camera.main.gameObject;
        //Debug.Log(camera.transform.position);

        GameObject[] objects = GameObject.FindGameObjectsWithTag("Objects");
        foreach (GameObject go in objects)
            Debug.Log(go.transform.position);
    }
}
