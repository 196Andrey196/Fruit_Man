using System.Collections;
using UnityEngine;

public class CollectionIndicator : MonoBehaviour
{
    private float _duration = 1f;
    private float _currentAlpha = 1f;
    private float _speed = 0.6f;
    private SpriteRenderer _spriteRenderer;
    private Vector3 _startPosition;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startPosition = transform.position;
    }

    public IEnumerator FadeAndMove()
    {

        float elapsedTime = 0f;
        Color startColor = _spriteRenderer.color;
        while (elapsedTime < _duration)
        {

            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / _duration);
            _spriteRenderer.color = new Color(startColor.r, startColor.g, startColor.b, alpha);
            Vector3 newPos = transform.position + Vector3.up * (_speed * Time.deltaTime);
            transform.position = newPos;

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = _startPosition;
        gameObject.SetActive(false);


    }
}
