using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private TMP_Text centerText;
    [SerializeField] private Image Image;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<SleighMove>().Finish();
            StartCoroutine(Finish());
        }
    }
    IEnumerator Finish()
    {
        centerText.text = "Finish!";
        centerText.alpha = 1;

        yield return new WaitForSeconds(1f);

        while(Image.color.a < 1)
        {
            yield return new WaitForSeconds(0.1f);
            Image.color += new Color(0, 0, 0, 0.1f);
        }

    }
}
