using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates1 : MonoBehaviour
{
    public static bool IsActive;
    private Vector3 tickerVector;
    void Start()
    {
        IsActive = false;
        tickerVector.Set(0, 0.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive)
        {
            if (transform.position.y >= 2)
            {
                tickerVector.Set(0, -0.2f, 0);
            }
            else if (transform.position.y <= 0.2)
            {
                tickerVector.Set(0, 0.2f, 0);
            }
            transform.Translate(tickerVector * Time.deltaTime);
        }
    }
    
}
