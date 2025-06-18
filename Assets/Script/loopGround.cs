using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopGround : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float width = 6f;

    private SpriteRenderer _spriteRenderer;

    private Vector2 startSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        startSize= new Vector2(_spriteRenderer.size.x,_spriteRenderer.size.y);

    }

    private void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + speed * Time.deltaTime, _spriteRenderer.size.y);

        if(_spriteRenderer.size.x > width)
        {
            _spriteRenderer.size = startSize;
        }
    }
}
