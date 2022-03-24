using UnityEngine;

public class PowerBallBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject ball;
    private Renderer renderer1;

    // Start is called before the first frame update
    void Start()
    {
        renderer1 = ball.GetComponent<Renderer>();
        Invoke("Disable", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //Disable();
        //color1 = Color.Lerp(Color.yellow, Color.blue, Mathf.PingPong(Time.time, 1));
        //ball.GetComponent<Renderer>().material.SetColor("_Color", color1);
    }

    void Disable()
    {
        renderer1.enabled = false;
        Invoke("Enable", 0.5f);
    }
    void Enable()
    {
        renderer1.enabled = true;
        Invoke("Disable", 0.5f);
    }
}
