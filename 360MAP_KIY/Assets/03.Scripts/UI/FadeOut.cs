using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    public CanvasGroup uiElement;
    public GameObject arrow;
    public GameObject menuBtn;
    public GameObject gameUI;
    public float time = 6f;

	private void Start()
	{
        Invoke("Fade", time);
        Invoke("ShowBG", time);
	}

    public void ShowBG()
	{
        arrow.SetActive(true);
        menuBtn.SetActive(true);
        gameUI.SetActive(true);
	}

	public void Fade()
    {
        StartCoroutine(FadeCanvasGroup(uiElement,uiElement.alpha,0));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = 0.5f)
    {
        float _timeStartedLerping = Time.time;
        float timeSinceStarted = Time.time - _timeStartedLerping;
        float percentageComplete = timeSinceStarted / lerpTime;

        while (true)
        {
            timeSinceStarted = Time.time - _timeStartedLerping;
            percentageComplete = timeSinceStarted / lerpTime;

            float currentValue = Mathf.Lerp(start,end,percentageComplete);

            cg.alpha = currentValue;

            if (percentageComplete >= 1) break;

            yield return new WaitForEndOfFrame();

        }
    }
}
