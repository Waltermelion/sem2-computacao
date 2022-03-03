using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 90, 0);
        transform.Translate(5, -1, 0);
        

        Debug.Log(transform.localPosition);

        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
