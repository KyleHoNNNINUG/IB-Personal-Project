using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public SlotAndCard.EVO ID;
    int anglex = -180, anglez = -8;
    float ix, iy, iz, fx, fy, fz;
    int xdir, ydir, zdir;
    float xdis, ydis, zdis;
    public void DrawAnimation(int rz = 0)
    {
        anglez = rz;
        InvokeRepeating("DrawRotation", 0.1f, 0.005f);
    }
    public void DrawAnimation(float fxp, float fyp, float fzp, int rz = 0)
    {
        anglez = rz;
        InvokeRepeating("DrawRotation", 0.1f, 0.0025f);
        ix = transform.position.x;
        iy = transform.position.y;
        iz = transform.position.z;
        fx = fxp;
        fy = fyp;
        fz = fzp;
        if (ix < fx) xdir = 1;
        else xdir = -1;
        if (iy < fy) ydir = 1;
        else ydir = -1;
        if (iz < fz) zdir = 1;
        else zdir = -1;
        InvokeRepeating("DrawTranslation", 0, 0.01f);
    }
    void DrawRotation()
    {
        transform.rotation = Quaternion.Euler(anglex, 0, anglez);
        if (anglex < 0)
        {
            anglex++;
        }
        else
        {
            CancelInvoke("DrawRotation");
            anglex = -180;
        }
    }
    void DrawTranslation()
    {
        xdis = xdir * (fx - transform.position.x);
        ydis = ydir * (fy - transform.position.y);
        zdis = zdir * (fz - transform.position.z);
        if (xdis > 0 || ydis > 0 || zdis > 0)
        {
            Vector3 v = new Vector3((fx - ix) / 30, (fy - iy) / 30, (fz - iz) / 30);
            transform.position += v;
        }
        else
        {
            CancelInvoke("DrawTranslation");
        }
    }
}
