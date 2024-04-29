using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private Text clockText;
    private float time;
    void Start()
    {
        time = 0;
        clockText = GetComponent<Text>();
    }
    void LateUpdate()
    {
        time += Time.deltaTime;
        int t = (int)time;
        int h = t / 3600;
        int m = (t % 3600) / 60;
        int s = t % 60;
        clockText.text =
        (h < 10 ? "0" : "") + h + ":" +
        (m < 10 ? "0" : "") + m + ":" +
        (s < 10 ? "0" : "") + s;
    }
}