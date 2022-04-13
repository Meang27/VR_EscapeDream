using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Talk_2 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

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
        
    }

    public IEnumerator StartDialogue()
    {
        StartTalking("여긴 간단해 그냥 골인지점까지 도착하면 성공이야.", 5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(5.0f);
        Del(dialogueBox2);

        StartTalking("상단에 뜨는 단어와 같은 모양을 선택하며 앞으로 나아가면 돼.", 5.5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(5.5f);
        Del(dialogueBox2);

        StartTalking("그럼 골인지점에서 보자고!", 2f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(2.0f);
        Del(dialogueBox2);
    }
}
