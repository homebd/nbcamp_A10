using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private float time;
    public bool TimeOver;
    public float FailPanelty = 3; // ���� �г�Ƽ 
    public float RedTime; // ��� �ð�
    public float EndTime; // ���� �ð�
    public int NumTotal;
    public int NumFail;
    public Text timeTxt;
    public Text FailNumTxt;
    public Text TotalNumTxt;
    public GameObject endTxt;
    public GameManager gameManager;
    public GameObject NumCanvas;
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
        SetNumCanvas();
        NumCanvas.SetActive(true);
        Time.timeScale = 0;
        endTxt.SetActive(true);
    }

    public void PlusNumFail()
    {
        NumFail++;
        NumTotal++;
    }
    public void PlusTotal()
    {
        NumTotal++;
    }
    public void SetNumCanvas()
    {
        FailNumTxt.text = NumFail.ToString();
        TotalNumTxt.text = NumTotal.ToString();
    }
    public void Penalty()
    {
        time += FailPanelty;
    }

}
