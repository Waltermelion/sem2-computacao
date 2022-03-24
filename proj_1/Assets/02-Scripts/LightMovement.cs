using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] private float topLeftCord;
    [SerializeField] private float bottomLeftCord;
    [SerializeField] private float bottomRightCord;
    [SerializeField] private float topRightCord;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
        if(direction == Vector3.left && transform.position.x <= topLeftCord)
        {
            direction = Vector3.back;
        }
        if (direction == Vector3.back && transform.position.z <= bottomLeftCord)
        {
            direction = Vector3.right;
        }
        if (direction == Vector3.right && transform.position.x >= bottomRightCord)
        {
            direction = Vector3.forward;
        }
        if (direction == Vector3.forward && transform.position.z >= topRightCord)
        {
            direction = Vector3.left;
        }
    }
}
