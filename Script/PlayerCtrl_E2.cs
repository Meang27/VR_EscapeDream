using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PlayerCtrl_E2 : MonoBehaviour
{
    public Image CursorGaugeImage;
    private float GaugeTimer = 0.0f;
    public GameObject mainCam;
    public static float time = 0.0f;

    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    private bool a = false;
    private bool b = false;

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
        time += Time.deltaTime;
        RaycastHit hit;
        Vector3 forward = mainCam.transform.TransformDirection(Vector3.forward);
        Debug.DrawRay(this.transform.position, forward * 50, Color.green);
        CursorGaugeImage.fillAmount = GaugeTimer;


        if (Physics.Raycast(transform.position, forward, out hit))
        {
            if (hit.transform.tag.Equals("Restart") && !a)
            {
                GaugeTimer += 1.0f / 3.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    a = true;
                    GaugeTimer = 0.0f;
                    SceneManager.LoadScene("Stage2");
                }
            }

            else if (hit.transform.tag.Equals("End") && !b)
            {
                GaugeTimer += 1.0f / 3.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    b = true;
                    GaugeTimer = 0.0f;
                    StartCoroutine(Talk());
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

    public IEnumerator Talk()
    {
        StartTalking("넌 이제 나와 함께 꿈속세계에서 지내는거야", 4f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(4.0f);
        Del(dialogueBox2);

        StartTalking("어때, 즐겁지않니??하하하하하!", 3f, dialogueBox2, dialogueText2);
    }
}
