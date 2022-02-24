using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private bool isRight = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void isClicked()
    {
        if (isRight)
        {
            Vector3 yest = cube.transform.position;
            yest.x -= 0.1f;
            cube.transform.position = yest;
            if(yest.x <= -2.05f)
            {
                isRight = false;
            }
        }else if (!isRight)
        {
            Vector3 yest = cube.transform.position;
            yest.x += 0.1f;
            cube.transform.position = yest;
            if (yest.x >= 2f)
            {
                isRight = true;
            }
        }
        
    }
}
