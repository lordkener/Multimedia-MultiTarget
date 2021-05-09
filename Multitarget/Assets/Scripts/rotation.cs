using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject sphereOne;
    public int direction;
    private Vector3 convert;
    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        switch (direction)
        {
            case 0:
                convert = sphereOne.transform.up + sphereOne.transform.forward;
                velocity = 300;
                break;
            case 1:
                convert = -sphereOne.transform.up;
                velocity = 100;
                break;
            case 2:
                convert = sphereOne.transform.up + sphereOne.transform.forward;
                velocity = 150;
                break;
            case 3:
                convert = -sphereOne.transform.up;
                velocity = 150;
                break;
            case 4:
                convert = sphereOne.transform.up;
                velocity = 100;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sphereOne.transform.position, convert, velocity * Time.deltaTime);
    }
}
