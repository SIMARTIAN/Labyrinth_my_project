using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CheckPoint2 : MonoBehaviour
{
    public Text Clock;
    public Text CheckTime;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.name );
        if (other.name.Equals("Ball"))
        {
            Gates1.IsActive = true;               //Open Gates1 
            CheckTime.text = Clock.text;          //Fix Checkpoint time
            this.gameObject.SetActive(false);     //Hide checkpoint object
        }
    }
}
