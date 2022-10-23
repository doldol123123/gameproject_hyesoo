using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextCut : MonoBehaviour
{
    public Image NextCutImage1;
    public Image NextCutImage2;
    public Image NextCutImage3;

    float time = 0f;
    float F_time = 1f;

    float time2 = 0f;
    float F_time2 = 1f;

    float time3 = 0f;
    float F_time3 = 1f;
    public void NextCutGo()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        NextCutImage1.gameObject.SetActive(true);
        Color alpha = NextCutImage1.color;

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            NextCutImage1.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo2()
    {
        StartCoroutine(FadeFlow2());
    }

    IEnumerator FadeFlow2()
    {
        NextCutImage2.gameObject.SetActive(true);
        Color alpha = NextCutImage2.color;

        while (alpha.a < 1f)
        {
            time2 += Time.deltaTime / F_time2;
            alpha.a = Mathf.Lerp(0, 1, time2);
            NextCutImage2.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo3()
    {
        StartCoroutine(FadeFlow3());
    }

    IEnumerator FadeFlow3()
    {
        NextCutImage3.gameObject.SetActive(true);
        Color alpha = NextCutImage3.color;

        while (alpha.a < 1f)
        {
            time3 += Time.deltaTime / F_time3;
            alpha.a = Mathf.Lerp(0, 1, time3);
            NextCutImage3.color = alpha;
            yield return null;
        }
        yield return null;

    }

    private void Update()
    {

        Color alpha = NextCutImage1.color;
        Color alpha2 = NextCutImage2.color;


        if (Input.GetKeyUp(KeyCode.Space))
        {

            NextCutGo();
        }
        
        if (alpha.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo2();
            }
        }
        
        if (alpha2.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo3();
            }
        }
    }

}
