using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong2 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow2Sound;
    private Animator anim2;


    void Start()
    {
        cow2Sound = GetComponent<AudioSource>();
        anim2 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow2Sound.Play();
        anim2.SetBool("isStanding2", true);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        anim2.SetBool("isStanding2", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow2Sound.Stop();
    }

}
