using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect : MonoBehaviour
{
    private CanvasGroup canvasGroup;

    // Start is called before the first frame update
    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    // Update is called once per frame

    public void OpenClose()
    {
        //Changes the alpaha to open or closed
        canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1;

        //Blocks or removes raycast blocking
        canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true ? false : true;

    }

    public void Open()
    {
        canvasGroup.alpha = 1f;

        canvasGroup.blocksRaycasts = true;
    }
    public void Close()
    {
        canvasGroup.alpha = 0f;

        canvasGroup.blocksRaycasts = false;
    }
    public IEnumerator CoFade(float fadeOutTime, float waitTime, float fadeOutTime1)
    {

        float tempColor = canvasGroup.alpha;
        while (tempColor < 1f)
        {
            tempColor += Time.deltaTime / fadeOutTime;
            canvasGroup.alpha = tempColor;

            if (tempColor >= 1f) tempColor = 1f;
            yield return null;
        }

        canvasGroup.alpha = tempColor;
        yield return new WaitForSeconds(waitTime);
        StartCoroutine(CoFadeOut(fadeOutTime1));
    }
    public IEnumerator CoFadeIn(float fadeOutTime)
    {

        float tempColor = canvasGroup.alpha;
        while (tempColor < 1f)
        {
            tempColor += Time.deltaTime / fadeOutTime;
            canvasGroup.alpha = tempColor;

            if (tempColor >= 1f) tempColor = 1f;
            yield return null;
        }

        canvasGroup.alpha = tempColor;

    }
    // 불투명 -> 투명
    public IEnumerator CoFadeOut(float fadeOutTime)
    {
        float tempColor = canvasGroup.alpha;
        while (tempColor > 0f)
        {
            tempColor -= Time.deltaTime / fadeOutTime;
            canvasGroup.alpha = tempColor;

            if (tempColor <= 0f) tempColor = 0f;

            yield return null;
        }

        canvasGroup.alpha = tempColor;

    }

}
