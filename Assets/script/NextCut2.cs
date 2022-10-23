using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextCut2 : MonoBehaviour
{
    public Image NextCutImage1;
    public Image NextCutImage2;
    public Image NextCutImage3;
    public Image NextCutImage4;
    public Image NextCutImage5;
    public Image NextCutImage6;
    public Image NextCutImage7;
    public Image NextCutImage8;
    public Image NextCutImage9;

    float time = 0f;
    float F_time = 1f;

    float time2 = 0f;
    float F_time2 = 1f;

    float time3 = 0f;
    float F_time3 = 1f;

    float time4 = 0f;
    float F_time4 = 1f;

    float time5 = 0f;
    float F_time5 = 1f;

    float time6 = 0f;
    float F_time6 = 1f;

    float time7 = 0f;
    float F_time7 = 1f;

    float time8 = 0f;
    float F_time8 = 1f;

    float time9 = 0f;
    float F_time9 = 1f;
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

    public void NextCutGo4()
    {
        StartCoroutine(FadeFlow4());
    }

    IEnumerator FadeFlow4()
    {
        NextCutImage4.gameObject.SetActive(true);
        Color alpha = NextCutImage4.color;

        while (alpha.a < 1f)
        {
            time4 += Time.deltaTime / F_time4;
            alpha.a = Mathf.Lerp(0, 1, time4);
            NextCutImage4.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo5()
    {
        StartCoroutine(FadeFlow5());
    }

    IEnumerator FadeFlow5()
    {
        NextCutImage5.gameObject.SetActive(true);
        Color alpha = NextCutImage5.color;

        while (alpha.a < 1f)
        {
            time5 += Time.deltaTime / F_time5;
            alpha.a = Mathf.Lerp(0, 1, time5);
            NextCutImage5.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo6()
    {
        StartCoroutine(FadeFlow6());
    }

    IEnumerator FadeFlow6()
    {
        NextCutImage6.gameObject.SetActive(true);
        Color alpha = NextCutImage6.color;

        while (alpha.a < 1f)
        {
            time6 += Time.deltaTime / F_time6;
            alpha.a = Mathf.Lerp(0, 1, time6);
            NextCutImage6.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo7()
    {
        StartCoroutine(FadeFlow7());
    }

    IEnumerator FadeFlow7()
    {
        NextCutImage7.gameObject.SetActive(true);
        Color alpha = NextCutImage7.color;

        while (alpha.a < 1f)
        {
            time7 += Time.deltaTime / F_time7;
            alpha.a = Mathf.Lerp(0, 1, time7);
            NextCutImage7.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo8()
    {
        StartCoroutine(FadeFlow8());
    }

    IEnumerator FadeFlow8()
    {
        NextCutImage8.gameObject.SetActive(true);
        Color alpha = NextCutImage8.color;

        while (alpha.a < 1f)
        {
            time8 += Time.deltaTime / F_time8;
            alpha.a = Mathf.Lerp(0, 1, time8);
            NextCutImage8.color = alpha;
            yield return null;
        }
        yield return null;

    }

    public void NextCutGo9()
    {
        StartCoroutine(FadeFlow9());
    }

    IEnumerator FadeFlow9()
    {
        NextCutImage9.gameObject.SetActive(true);
        Color alpha = NextCutImage9.color;

        while (alpha.a < 1f)
        {
            time9 += Time.deltaTime / F_time9;
            alpha.a = Mathf.Lerp(0, 1, time9);
            NextCutImage9.color = alpha;
            yield return null;
        }
        yield return null;

    }

    private void Update()
    {

        Color alpha = NextCutImage1.color;
        Color alpha2 = NextCutImage2.color;
        Color alpha3 = NextCutImage3.color;
        Color alpha4 = NextCutImage4.color;
        Color alpha5 = NextCutImage5.color;
        Color alpha6 = NextCutImage6.color;
        Color alpha7 = NextCutImage7.color;
        Color alpha8 = NextCutImage8.color;


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

        if (alpha3.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo4();
            }
        }

        if (alpha4.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo5();
            }
        }

        if (alpha5.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo6();
            }
        }

        if (alpha6.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo7();
            }
        }

        if (alpha7.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo8();
            }
        }

        if (alpha8.a > 0f)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {

                NextCutGo9();
            }
        }
    }
}
