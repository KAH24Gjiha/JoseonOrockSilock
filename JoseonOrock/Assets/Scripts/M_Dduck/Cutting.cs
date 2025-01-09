using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Cutting : MonoBehaviour
{
    private StartView start;
    [SerializeField] private TMP_Text countText;

    private int cutCount;
    // Start is called before the first frame update
    void Start()
    {
        start = GameObject.Find("Canvas").GetComponent<StartView>();
    }

    public void Cut()
    {
        if (start.isStart == true)
        {
            cutCount++;
        }
        countText.text = cutCount.ToString();
    }
}
