using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong5 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow5Sound;
    private Animator anim5;


    void Start()
    {
        cow5Sound = GetComponent<AudioSource>();
        anim5 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow5Sound.Play();
        anim5.SetBool("isStanding5", true);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        anim5.SetBool("isStanding5", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow5Sound.Stop();
    }

}

