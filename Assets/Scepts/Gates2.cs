using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gates2 : MonoBehaviour
{
    public static bool IsActive;
    private Vector3 rotor;
    void Start()
    {
        IsActive = false;
        rotor.Set(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsActive)
        {
            rotor.y =Time.deltaTime * 5;
            this.transform.Rotate(rotor);
        }
    }
}
