using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private AudioSource cow1Sound;
    private Animator anim1;
    private float timer = 0.0f;
    private float timerDelta = 0.0f;
    private float tDelta = 0.5f;
    private double dspDelta;

    void Start()
    {
        cow1Sound = GetComponent<AudioSource>();
        anim1 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        timer = Time.time;
        print(timer);
        cow1Sound.Play ();
        anim1.SetBool("isStanding", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        anim1.SetBool("isStanding", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow1Sound.Stop();
    }

}
