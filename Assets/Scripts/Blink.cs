using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Blink : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public float blinkInterval = 0.5f;

    private bool isVisible = true;

    void Start()
    {
        StartCoroutine(BlinkText());
    }

    IEnumerator BlinkText()
    {
        while (true)
        {
            textComponent.enabled = isVisible;
            isVisible = !isVisible;
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}