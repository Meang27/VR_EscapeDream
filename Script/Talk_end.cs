using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Talk_end : MonoBehaviour
{

    public GameObject dialogueBox_end1;
    public GameObject dialogueBox_end2;
    public Text dialogueText_end1;
    public Text dialogueText_end2;

    public GameObject Butt;
    public GameObject OverText;

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
        yield return new WaitForSeconds(1.0f);
        StartTalking("목숨을 모두 잃어서 너는 현실세계로\n되돌아갈 수 없게 되었어", 5.5f, dialogueBox_end2, dialogueText_end2);
        yield return new WaitForSeconds(5.5f);
        Del(dialogueBox_end2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("다시 도전할래??", 1.5f, dialogueBox_end2, dialogueText_end2);
        yield return new WaitForSeconds(1.5f);
        Del(dialogueBox_end2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("다시 도전할까?\n아니면 이대로 꿈속에서 지낼까?", 4f, dialogueBox_end1, dialogueText_end1);
        yield return new WaitForSeconds(4.0f);
        Del(dialogueBox_end1);

        OverText.SetActive(false);
        Butt.SetActive(true);
        
    }
}
