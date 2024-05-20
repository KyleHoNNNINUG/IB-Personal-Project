using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAction : MonoBehaviour
{
    bool paused = false, setting = false;
    public GameObject[] UIObjects;
    public void PauseMenu()
    {
        paused = !paused;
        UIObjects[0].SetActive(paused);
    }
    public void HandsMenu()
    {
        UIObjects[1].SetActive(!UIObjects[1].activeSelf);
    }
    public void SettingMenu(bool display = true)
    {
        UIObjects[2].SetActive(display);
        setting = display;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }

    // Update is called once per frame
    void Update()
    {
        if (CompareTag("Manager"))
        {
            if (!setting)
            {
                if (Input.GetKeyDown(KeyCode.Escape)) PauseMenu();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Escape)) SettingMenu(false);
                if (Input.GetKeyDown(KeyCode.RightArrow)) GetComponent<SlotAndCard>().ChangeMaxCardCount(true);
                if (Input.GetKeyDown(KeyCode.LeftArrow)) GetComponent<SlotAndCard>().ChangeMaxCardCount(false);
            }
            if (!paused)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow)) GetComponent<SlotAndCard>().SwitchHand(true);
                if (Input.GetKeyDown(KeyCode.LeftArrow)) GetComponent<SlotAndCard>().SwitchHand(false);
                if (Input.GetKeyDown(KeyCode.UpArrow)) HandsMenu();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow)) SettingMenu();
            }
        }
    }
}
