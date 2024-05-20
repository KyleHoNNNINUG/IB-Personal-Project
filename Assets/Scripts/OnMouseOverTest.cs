using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseOverTest : MonoBehaviour
{
    public GameObject[] moved;
    private Vector3 vector;
    private int currentNumber = 0;
    private int cord = 3;
    private int counter = 0;
    private int target = 99;
    private float temp;

    private void ResetCounter()
    {
        counter = 0;
    }
    private void SetCord(int cordnum)
    {
        cord = cordnum;
    }
    public void ContMove(float a)
    {
        target = 10;
        temp = a / 10;
        InvokeRepeating("MoveCurrent", 0, 0.03f);
    }    
    private void MoveCurrent()
    {
        if (counter < target)
        {
            switch (cord)
            {
                case 1:
                    vector = new Vector3(temp, 0, 0);
                    break;
                case 2:
                    vector = new Vector3(0, temp, 0);
                    break;
                case 3:
                    vector = new Vector3(0 - temp, 0, 0);
                    break;
                case 4:
                    vector = new Vector3(0, 0 - temp, 0);
                    break;
                default:
                    break;
            }
            moved[currentNumber].transform.position += vector;
            counter++;
        }
        else
        {
            CancelInvoke("MoveCurrent");
            ResetCounter();
        }
    }


    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        ContMove((float)1.5);
        
    }

    void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        Debug.Log("Mouse is no longer on GameObject.");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
