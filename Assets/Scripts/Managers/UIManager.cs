using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private float time;
    public bool TimeOver;
    public float RedTime; // ��� �ð�
    public float EndTime; // ���� �ð�
    public Text timeTxt;
    public GameObject endTxt;
    public GameManager gameManager;
    // Update is called once per frame

    private void Awake()
    {
        TimeOver = false;
    }
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
        if (time >= RedTime)
        {
            timeTxt.color = Color.red;
            if (time >= EndTime)
            {
                TimeOver = true;
                ActiveEndText();
            }

        }
    }

    public void ActiveEndText()
    {
        Time.timeScale = 0;
        endTxt.SetActive(true);
    }

}
