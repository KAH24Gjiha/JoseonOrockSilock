using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Finished : MonoBehaviour
{
    
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private TMP_Text centerText;
    [SerializeField] private Image Image;
    private StartView start;

    private float time = 15;
    void Start()
    {
        start = GameObject.Find("Canvas").GetComponent<StartView>();
    }

    private void Update()
    {
        if(start.isStart && time > 0)
        {
            time -= Time.deltaTime;
            timeText.text = string.Format("{0:N2}", time);
        }
        else if (start.isStart)
        {
            timeText.text = "0";
            start.isStart = false;
            StartCoroutine(Finish());
        }
    }
    IEnumerator Finish()
    {
        Image.gameObject.SetActive(true);

        centerText.text = "Finish!";
        centerText.alpha = 1;

        yield return new WaitForSeconds(1f);

        while (Image.color.a < 1)
        {
            yield return new WaitForSeconds(0.1f);
            Image.color += new Color(0, 0, 0, 0.1f);
        }

    }
}
