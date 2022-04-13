using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Quiz_1 : MonoBehaviour
{
    public GameObject dialogueBox1;
    public GameObject dialogueBox2;
    public Text dialogueText1;
    public Text dialogueText2;

    public static int heart = 3;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject ten;
    public GameObject eleven;
    public GameObject twelve;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    //public GameObject heart4;
    public GameObject heart_d1;
    public GameObject heart_d2;
    public GameObject heart_d3;
    //public GameObject heart_d4;

    public GameObject C3;
    public GameObject C2;
    public GameObject C1;

    public GameObject ClearText;
    // Start is called before the first frame update

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
    void Start()
    {
        StartCoroutine(quiz());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator quiz()
    {
        yield return new WaitForSeconds(12.5f);
        C3.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        C3.SetActive(false);
        C2.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        C2.SetActive(false);
        C1.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        C1.SetActive(false);

        one.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        one.SetActive(false);

        yield return new WaitForSeconds(0.3f);
        two.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        two.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        three.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        three.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        four.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        four.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        five.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        five.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        six.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        six.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        seven.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        seven.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        eight.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        eight.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        nine.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        nine.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        ten.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        ten.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        eleven.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        eleven.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        twelve.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        twelve.SetActive(false);
    }

    public IEnumerator ClearS1()
    {
        StartTalking("성공! 다음스테이지로 넘어가보자구~~", 4f, dialogueBox2, dialogueText2);
        yield return new WaitForSeconds(4.0f);
        Del(dialogueBox2);
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("Stage2");

    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "one")
        {
            Destroy(col.gameObject);
            one.SetActive(false);
            two.SetActive(true);
        }

        else if (col.gameObject.tag == "two")
        {
            Destroy(col.gameObject);
            two.SetActive(false);
            three.SetActive(true);
        }

        else if (col.gameObject.tag == "three")
        {
            Destroy(col.gameObject);
            three.SetActive(false);
            four.SetActive(true);
        }

        else if (col.gameObject.tag == "four")
        {
            Destroy(col.gameObject);
            four.SetActive(false);
            five.SetActive(true);
        }

        else if (col.gameObject.tag == "five")
        {
            Destroy(col.gameObject);
            five.SetActive(false);
            six.SetActive(true);
        }

        else if (col.gameObject.tag == "six")
        {
            Destroy(col.gameObject);
            six.SetActive(false);
            seven.SetActive(true);
        }

        else if (col.gameObject.tag == "seven")
        {
            Destroy(col.gameObject);
            seven.SetActive(false);
            eight.SetActive(true);
        }

        else if (col.gameObject.tag == "eight")
        {
            Destroy(col.gameObject);
            eight.SetActive(false);
            nine.SetActive(true);
        }

        else if (col.gameObject.tag == "nine")
        {
            Destroy(col.gameObject);
            nine.SetActive(false);
            ten.SetActive(true);
        }

        else if (col.gameObject.tag == "ten")
        {
            Destroy(col.gameObject);
            ten.SetActive(false);
            eleven.SetActive(true);
        }

        else if (col.gameObject.tag == "eleven")
        {
            Destroy(col.gameObject);
            eleven.SetActive(false);
            twelve.SetActive(true);
        }

        else if (col.gameObject.tag == "twelve")
        {
            Destroy(col.gameObject);
            twelve.SetActive(false);
        }

        else if (col.gameObject.tag == "Fbox")
        {
            HeadMove.moveSpeed = 0.0f;
            HeadMove.runSpeed = 0.0f;
            ClearText.SetActive(true);
            StartCoroutine(ClearS1());
        }

        else
        {
            heart--;
            if(heart == 2)
            {
                heart1.SetActive(false);
                heart_d1.SetActive(true);
            }

            else if (heart == 1)
            {
                heart2.SetActive(false);
                heart_d2.SetActive(true);
            }

            else if (heart == 0)
            {
                heart3.SetActive(false);
                heart_d3.SetActive(true);
            }

            Debug.Log(heart);
            Destroy(col.gameObject);
            
        }
    }
}
