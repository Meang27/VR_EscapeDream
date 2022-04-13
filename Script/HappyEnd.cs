using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HappyEnd : MonoBehaviour
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
        yield return new WaitForSeconds(1.0f);
        Sheep.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        StartTalking("모든 스테이지를 다 깼구나! 이거 섭섭한걸~?\n나랑 더 같이 있을 수 있었는데...", 6f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(6f);
        Del(dialogueBox2);

        StartTalking("널 이제 현실세계로 돌려보내려해 그럼 다음에 또 보자고 친구!!", 5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(5f);
        Del(dialogueBox2);

        Stage.SetActive(true);

    }
}
