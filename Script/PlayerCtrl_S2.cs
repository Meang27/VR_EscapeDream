using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PlayerCtrl_S2 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    public Image CursorGaugeImage;
    public GameObject mainCam;
    public static float time = 0.0f;
    private float GaugeTimer = 0.0f;
    //private float gazeTime = 2.0f;
    private float walkSpeed = 5.0f;
    private bool isMoving = false;
    private Vector3 goalPosition;

    private bool a = false;
    private bool b = false;
    private bool c = false;
    private bool d = false;
    private bool e = false;
    private bool f = false;
    private bool g = false;
    private bool h = false;
    private bool i = false;
    private bool j = false;
    private bool k = false;

    public static bool star = false;
    public GameObject ClearText;

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
            if (hit.transform.tag.Equals("C1") && !a)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    a = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C2") && !b)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    b = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C3") && !c)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    c = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C4") && !d)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    d = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }


            else if (hit.transform.tag.Equals("C5") && !e)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    e = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C6") && !f)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    f = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C7") && !g)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    g = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C8") && !h)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    h = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C9") && !i)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    i = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("C10") && !j)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    j = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
                }
            }

            else if (hit.transform.tag.Equals("Star") && !k)
            {
                GaugeTimer += 1.0f / 2.0f * Time.deltaTime;
                if (GaugeTimer >= 1.0f)
                {
                    k = true;
                    GaugeTimer = 0.0f;
                    goalPosition = new Vector3(hit.transform.position.x, this.transform.position.y, hit.transform.position.z);
                    isMoving = true;
                    StartCoroutine(MoveForward());
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

    IEnumerator MoveForward()
    {
        while (isMoving)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, goalPosition, Time.deltaTime * walkSpeed);
            yield return null;
        }
    }

    IEnumerator ClearS2()
    {
        StartTalking("별을 찾았네!! 좀더 어려운 곳에 숨길걸 그랬나?^^", 5f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(4.0f);
        Del(dialogueBox2);
        SceneManager.LoadScene("Happy");
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "C1")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C2")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C3")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C4")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C5")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C6")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C7")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C8")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C9")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "C10")
        {
            isMoving = false;
        }

        else if (col.gameObject.tag == "Star")
        {
            isMoving = false;
            ClearText.SetActive(true);
            StartCoroutine(ClearS2());
        }
    }
}
