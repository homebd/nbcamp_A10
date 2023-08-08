using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private float time;
    public float RedTime; // ��� �ð�
    public float EndTime; // ���� �ð�
    public Text timeTxt;
    public GameObject endTxt;
    public GameManager gameManager;
    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeTxt.text = time.ToString("N2");
        if (time >= RedTime)
        {
            timeTxt.color = Color.red;
            if (time >= EndTime)
            {
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
