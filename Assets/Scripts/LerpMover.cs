using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMover : MonoBehaviour
{
    public Vector2 startPosition;
    public Vector2 endPosition;
    public float step;
    private float progress;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(startPosition, endPosition,progress);
        progress += step;
    }
}
