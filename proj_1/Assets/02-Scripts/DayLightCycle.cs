using UnityEngine;

public class DayLightCycle : MonoBehaviour
{ 
    //[SerializeField] private float RotationSpeed;
    [SerializeField] private float StartingXRotation;
    void Update()
    {
        //StartingXRotation += RotationSpeed;
        transform.Rotate(StartingXRotation, 0, 0);
    }
}
