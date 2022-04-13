using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Talk_1 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    public GameObject Sheep;
    public GameObject Stage;

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
        StartTalking("어..?여긴 어디지..?\n처음 보는 곳인데...", 5f, dialogueBox1, dialogueText1);
        yield return new WaitForSeconds(5.0f);
        Del(dialogueBox1);

        Sheep.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        StartTalking("안녕! 반가워!", 2.5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(2.5f);
        Del(dialogueBox2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("누...누구세요???", 2.5f, dialogueBox1, dialogueText1);
        yield return new WaitForSeconds(2.5f);
        Del(dialogueBox1);

        yield return new WaitForSeconds(1.0f);
        StartTalking("지금 여기는 너의 꿈속이야.\n나는 너의 꿈속에서 지내고 있는 메리라고해.", 7f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(7.0f);
        Del(dialogueBox2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("꿈속이라고??\n너무 깊게 잠들었나...", 3.5f, dialogueBox1, dialogueText1);
        yield return new WaitForSeconds(3.5f);
        Del(dialogueBox1);

        yield return new WaitForSeconds(1.0f);
        StartTalking("하지만 너가 꿈속으로 들어온 이상\n나가는건 마음대로 되지 않을거야.", 7f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(7.0f);
        Del(dialogueBox2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("그럼 어떻게해야 내가 꿈속을 나갈수 있는거지?", 5f, dialogueBox1, dialogueText1);
        yield return new WaitForSeconds(5.0f);
        Del(dialogueBox1);

        yield return new WaitForSeconds(1.0f);
        StartTalking("여긴 총 2개의 스테이지가 있어.\n이 스테이지를 모두 클리어하면 내가\n현실세계로 보내줄게.", 8f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(8.0f);
        Del(dialogueBox2);

        yield return new WaitForSeconds(1.0f);
        StartTalking("그래, 알겠어 해볼게!", 2f, dialogueBox1, dialogueText1);
        yield return new WaitForSeconds(2.0f);
        Del(dialogueBox1);

        yield return new WaitForSeconds(1.0f);
        StartTalking("꿈속에서 너의 목숨은 3개야.\n이점 잘 생각하고 게임해!", 6f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(6.0f);
        Del(dialogueBox2);

        Stage.SetActive(true);
    }
}
