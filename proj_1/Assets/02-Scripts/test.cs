using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField] private GameObject thicc;
    [SerializeField] private bool isRight = true;
    [SerializeField] private GameObject bola;
    [SerializeField] private GameObject spawner;

    public void Start()
    {
        Debug.Log("yes");
    }  
    
    public void isClicked()
    {
        Vector3 yest = thicc.transform.position;
        Instantiate(bola, spawner.transform.position, spawner.transform.rotation);

        if (isRight)
        {            
            yest.x -= 0.2f;
            thicc.transform.position = yest;
            if(yest.x <= -2.05f)
            {
                isRight = false;
            }
        }else
        {            
            yest.x += 0.2f;
            thicc.transform.position = yest;
            if (yest.x >= 2f)
            {
                isRight = true; // medium fries
            }
        }
        
    }
}