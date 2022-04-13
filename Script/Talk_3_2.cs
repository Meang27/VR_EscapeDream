using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Talk_3_2 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    public static int heart = 3;
    public float LimitTime = 45.0f;
    public Text text_Timer;

    public bool time = false;

    void Pop(GameObject Image)
    {
        Image.SetActive(true);
    }

    void Del(GameObject TB)
    {
        TB.SetActive(false);
    }

    public void StartTalking(string dialogue, float duration, GameObject tB, Text tT)
    {
        tB.SetActive(true);
        tT.text = "";
        tT.DOText(dialogue, duration);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LimitTime > 0.0f)
        {
            LimitTime -= Time.deltaTime;
            text_Timer.text = Mathf.Round(LimitTime) + "";

            if (LimitTime < 0)
            {
                SceneManager.LoadScene("End2");
                Talk_3.heart = 3;
            }
        }
    }

}
