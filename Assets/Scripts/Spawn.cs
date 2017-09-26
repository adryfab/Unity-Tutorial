using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject prefab;
    private int count = 0;

	// Use this for initialization
	void Start ()
    {
        //Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject cube = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
            cube.name = "foo" + count++;

            Physics physics = cube.GetComponent<Physics>();
            physics.Shoot();

            Destroy(cube, 3f);
        }
          
    }
}
