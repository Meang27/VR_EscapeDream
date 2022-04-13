using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Talk_3 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    public static int heart = 3;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject heart_d1;
    public GameObject heart_d2;
    public GameObject heart_d3;

    public GameObject Map;
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
        StartCoroutine(StartDialogue());
    }

    // Update is called once per frame
    void Update()
    {
        if (time == true && LimitTime > 0.0f)
        {
            LimitTime -= Time.deltaTime;
            text_Timer.text = Mathf.Round(LimitTime) + "";

            if(LimitTime < 0)
            {
                SceneManager.LoadScene("Stage3");
            }
        }

        else if (LimitTime == 0.0f)
        {
            heart--;
            Debug.Log(heart);
        }
    }
    

    public IEnumerator StartDialogue()
    {
        StartTalking("여기는 제한시간안에 이 집을 빠져나가 별을 찾으면 성공이야.", 5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(5.0f);
        Del(dialogueBox2);

        StartTalking("나갈수 있는 길은 알려줄게.\n잘기억하고 탈출해봐!", 4f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(4.0f);
        Del(dialogueBox2);

        Map.SetActive(true);

        StartTalking("별을 찾은후에 만나자고~", 2f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(2.0f);
        Del(dialogueBox2);

        yield return new WaitForSeconds(2.0f);
        Map.SetActive(false);
        time = true;
        
    }
}
