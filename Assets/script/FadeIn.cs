using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image BlackPanel;
    float time = 0f;
    float F_time = 1f;
    public void FadeInGo()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        BlackPanel.gameObject.SetActive(true);
        Color alpha = BlackPanel.color;

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            BlackPanel.color = alpha;
            yield return null;
        }
        yield return null;

    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {

            FadeInGo();
        }
    }

}
