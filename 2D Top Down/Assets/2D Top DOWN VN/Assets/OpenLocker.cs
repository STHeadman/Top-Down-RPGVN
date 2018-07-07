using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLocker : MonoBehaviour {

    float duration = 0.5f;

    void Start()
    {
        OpenLockerTrigger.OpenLocker += Open;
        OpenLockerTrigger.CloseLocker += Close;
    }
    public void Open()
    {

        StartCoroutine(Rotate(duration));
    }

    public void Close()
    {
        StartCoroutine(RotateBack(duration));
    }

    IEnumerator Rotate(float duration)
    {
        float startRotation = transform.eulerAngles.y;
        float endRotation = startRotation - 45.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float yRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
            yield return null;
        }
    }

    IEnumerator RotateBack(float duration)
    {
        float startRotation = transform.eulerAngles.y;
        float endRotation = startRotation  + 45.0f;
        float t = 0.0f;
        while (t < duration)
        {
            t += Time.deltaTime;
            float yRotation = Mathf.Lerp(startRotation, endRotation, t / duration) % 360.0f;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotation, transform.eulerAngles.z);
            yield return null;
        }
    }
}
