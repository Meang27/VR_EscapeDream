using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float LimitTime = 60;
    public Text text_Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LimitTime -= Time.deltaTime;
        text_Timer.text = Mathf.Round(LimitTime)+"";
    }
}
