using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject wKey;
    public GameObject sKey;
    public GameObject upKey;
    public GameObject downKey;

    public GameObject ball;

    private byte counter;

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            wKeyIsPressed();
        }
        else if (Input.GetKeyDown("s"))
        {
            sKeyIsPressed();
        }
        else if (Input.GetKeyDown("up"))
        {
            upKeyIsPressed();
        }
        else if (Input.GetKeyDown("down"))
        {
            downKeyIsPressed();
        }

        if(counter == 4)
        {
            ball.GetComponent<Ball>().Launch();
            counter = 0;
        }
    }

    void wKeyIsPressed()
    {
        if(wKey.activeSelf)
        {
            wKey.SetActive(false);
            counter++;
        }
    }

    void sKeyIsPressed()
    {
        if (sKey.activeSelf)
        {
            sKey.SetActive(false);
            counter++;
        }
    }

    void upKeyIsPressed()
    {
        if (upKey.activeSelf)
        {
            upKey.SetActive(false);
            counter++;
        }
    }

    void downKeyIsPressed()
    {
        if (downKey.activeSelf)
        {
            downKey.SetActive(false);
            counter++;
        }
    }
}
