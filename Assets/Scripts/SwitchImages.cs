using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SwitchImages : MonoBehaviour
{
    public GameObject[] text;
    public GameObject[] images;
    private int imageNumber;

    // Set ImageNumber to 0 on Load
    private void Start()
    {
        imageNumber = 0;
    }

    // By Pressing the Next Button, load the next Image in the list
    public void Next()
    {
        imageNumber++;

        if (imageNumber > images.Length -1)
        {
            imageNumber = 0;
        }

        SetImage();
        Debug.Log("Next");
    }

    // By Pressing the Previous Button, load the Previous Image in the list
    public void Previous()
    {
        imageNumber--;

        if(imageNumber < 0)
        {
            imageNumber = images.Length - 1;
        }
        SetImage();
        Debug.Log("Previous");
    }

    void SetImage ()
    {
        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(i == imageNumber);
            text[i].SetActive(i == imageNumber);
            Debug.Log("indexnumber: " + i);
        }
    }
}
