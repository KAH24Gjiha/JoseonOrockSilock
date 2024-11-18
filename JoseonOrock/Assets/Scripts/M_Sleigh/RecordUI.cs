using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecordUI : MonoBehaviour
{
    [SerializeField] private TMP_Text speedText;
    [SerializeField] private TMP_Text timeText;
    private Rigidbody rigid;

    float time;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        speedText.text = $"{(int)rigid.velocity.z} km/s";
        timeText.text = string.Format("{0:N2}", time);
    }
}
