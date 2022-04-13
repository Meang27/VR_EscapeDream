using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadMove : MonoBehaviour
{
    public GameObject mainCam;
    public static float moveSpeed = 0.0f;
    public static float runSpeed = 0.0f;
    private float positionX = 0.0f;
    //private float accel = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpeedUp());
    }

    // Update is called once per frame
    void Update()
    {
        positionX = this.transform.position.x - mainCam.transform.rotation.z * moveSpeed / 90.0f;

        this.transform.position = new Vector3(positionX, this.transform.position.y, this.transform.position.z);

        Run();

        if (Quiz_1.heart == 0)
        {
            moveSpeed = 0.0f;
            runSpeed = 0.0f;
            SceneManager.LoadScene("End");
            Quiz_1.heart = 3;
        }
    }

    void Run()
    {
        this.transform.position += this.transform.forward * runSpeed * Time.deltaTime;
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(15.6f);
        moveSpeed = 20.0f;
        runSpeed = 12.9f;

        Debug.Log(runSpeed);

        

        /*while (true)
        {
            yield return new WaitForSeconds(3.0f);

            runSpeed += accel;
        }*/
    }
}
