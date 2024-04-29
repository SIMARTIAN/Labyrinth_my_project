using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;


public class CheckPoint3 : MonoBehaviour
{
    public Text Clock;
    public Text CheckTime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("Ball"))
        {
            Gates2.IsActive = true;
            this.gameObject.SetActive(false);
        }      
           
    }
}
