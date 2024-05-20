using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    bool fadeOut = false;
    float t;
    public Image image;
    public GameObject imgobj;
    public void UnderdevelopmentStatement()
    {
        t = 2.0f;
        fadeOut = true;
        imgobj.SetActive(true);
    }
    void Awake()
    {
        image.color = new Color(1, 1, 1, 0.0f);
    }
    void Update()
    {
        if (fadeOut)
        {
            if (t == 0.0f)
            {
                imgobj.SetActive(false); 
                fadeOut = false;
            }
            t -= Time.deltaTime / 2;
            image.color = new Color(1, 1, 1, t);
        }
    }
}
