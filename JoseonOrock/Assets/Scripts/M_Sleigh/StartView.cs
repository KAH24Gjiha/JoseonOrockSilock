using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartView : MonoBehaviour
{
    public string minigameText;
    [SerializeField] private TMP_Text centerText;
    [SerializeField] private GameObject Image;

    public bool isStart;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScene());
    }

    IEnumerator StartScene()
    {
        centerText.text = minigameText;
        yield return new WaitForSeconds(3f);
        Image.SetActive(false);

        centerText.text = "3";
        yield return new WaitForSeconds(1f);
        centerText.text = "2";
        yield return new WaitForSeconds(1f);
        centerText.text = "1";
        yield return new WaitForSeconds(1f);
        centerText.text = "GO!";

        //GetComponent<SleighMove>().StartRace();
        isStart = true;

        while (centerText.alpha > 0)
        {
            yield return new WaitForSeconds(0.1f);
            centerText.alpha -= 0.1f;
        }
    }
}
