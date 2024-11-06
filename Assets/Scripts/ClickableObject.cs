using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ClickableObject : MonoBehaviour
{
    [SerializeField] private int minRange;
    [SerializeField] private int maxRange;
    [SerializeField] private Transform buttonTransform;

    private Transform defaultTransform;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
        defaultTransform = buttonTransform;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_camera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        ClickAnimation();

        Manager.Instance.IncreaseCurrency(1);
    }

    private void ClickAnimation()
    {
        
        int randomX = Random.Range(minRange, maxRange);
        int randomY = Random.Range(minRange, maxRange);

        Vector3 upscale = new Vector3(randomX, randomY, defaultTransform.localScale.z);

        StartCoroutine(ScaleUpAndDown(buttonTransform, upscale, 0.1f));

        //buttonTransform.localScale = new Vector3(randomX, randomY, defaultTransform.localScale.z);

    }

    IEnumerator ScaleUpAndDown(Transform transform, Vector3 upScale, float duration)
    {
        Vector3 initialScale = defaultTransform.localScale;


        for (float time = 0; time < duration * 2; time += Time.deltaTime)
        {
            float progress = Mathf.PingPong(time, duration) / duration;
            transform.localScale = Vector3.Lerp(initialScale, upScale, progress);
            yield return null;
        }

        transform.localScale = initialScale;
    }
}
