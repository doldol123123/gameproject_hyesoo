using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image BlackPanel;
    float time = 0f;
    float F_time = 1f;
    public void FadeOutGo()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        BlackPanel.gameObject.SetActive(true);
        Color alpha = BlackPanel.color;

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            BlackPanel.color = alpha;
            yield return null;
        }
        yield return null;

    }

    private void Start()
    {

         FadeOutGo();

    }
}
