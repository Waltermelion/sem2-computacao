using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTransformations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(transform.localPosition);
        Debug.Log(transform.localEulerAngles);
        Debug.Log(transform.localScale);

        Debug.Log(transform.position);
        Debug.Log(transform.eulerAngles);
        Debug.Log(transform.lossyScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
