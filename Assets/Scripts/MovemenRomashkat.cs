using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemenRomashkat : MonoBehaviour
{
    public Vector3 start; // начало
public Vector3 end; // конец
public float time; // время скейла
private float timer;
void Update()
{
 transform.position = Vector3.Lerp(start, end, Mathf.PingPong(timer, time));
 timer += Time.deltaTime;
}
}
