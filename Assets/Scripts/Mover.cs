using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public GameObject[] change;
    private Vector3 vector;
    private int currentNumber = 0;
    private int cord = 0;
    private int counter = 0;
    private int target = 99;
    private float temp;

    private void resetCounter()
    {
        counter = 0;
    }

    public void setCord(int cordnum)
    {
        cord = cordnum;
    }
    public void contMove(float a)
    {
        target = 10;
        temp = a / 10;
        InvokeRepeating("moveCurrent", 0, 0.03f);
    }

    public void current(int num)
    {
        currentNumber = num;
    }
    public void moveCurrent()
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
            change[currentNumber].transform.position += vector;
            counter++;
        }
        else
        {
            CancelInvoke("moveCurrent");
            resetCounter();
        }
    }


}
