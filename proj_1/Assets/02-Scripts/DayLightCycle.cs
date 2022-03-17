using UnityEngine;

public class DayLightCycle : MonoBehaviour
{ 
    [SerializeField] private float StartingXRotation;
    [SerializeField] private bool redLimit = false;
    void Update()
    {
        transform.Rotate(StartingXRotation, 0, 0);

        Color color1 = this.GetComponent<Light>().color;

        color1 = Color.Lerp(Color.white, Color.yellow, Mathf.PingPong(Time.time, 1));

        /*if (redLimit)
        {
            if (color1.r >= 1)
            {
                color1.r -= 0.001f;
            }
        }
        else
        {
            color1.r += 0.001f;
        }

        if(transform.localEulerAngles.x <= 0.1 || transform.localEulerAngles.x >= 20)
        {
            redLimit = true;
        }else if(transform.localEulerAngles.x >= 0.1 || transform.localEulerAngles.x <= 20)
        {
            redLimit = false;
        }*/

        this.GetComponent<Light>().color = color1; // Mudar para variavel = gameobjectgetcomponet
    }
}
