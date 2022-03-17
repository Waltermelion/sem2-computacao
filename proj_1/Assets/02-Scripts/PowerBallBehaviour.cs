using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Color color1;

    // Start is called before the first frame update
    void Start()
    {
        color1 = ball.GetComponent<Renderer>().material.color;        
    }

    // Update is called once per frame
    void Update()
    {
        color1 = Color.Lerp(Color.yellow, Color.blue, Mathf.PingPong(Time.time, 1));
        ball.GetComponent<Renderer>().material.SetColor("_Color", color1);
    }
}
