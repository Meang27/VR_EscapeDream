using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCtrl : MonoBehaviour
{
    public Image CursorGaugeImage;
    private float GaugeTimer = 0.0f;
    public GameObject mainCam;
    public static float time = 0.0f;

    private bool a = false;
    private bool b = false;
    private bool c = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(this.transform.position, forward * 50, Color.green);
        CursorGaugeImage.fillAmount = GaugeTimer;


        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.transform.tag.Equals("S1") && !a)
            {
                GaugeTimer += 1.0f / 3.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    a = true;
                    GaugeTimer = 0.0f;
                    SceneManager.LoadScene("Stage1");
                }
            }

            else if(hit.transform.tag.Equals("S2") && !b)
            {
                GaugeTimer += 1.0f / 3.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    b = true;
                    GaugeTimer = 0.0f;
                    SceneManager.LoadScene("Stage1");
                }
            }

            else
            {
                GaugeTimer = 0.0f;
            }
        }
        else
            GaugeTimer = 0.0f;
    }
}
