using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong6 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow6Sound;
    private Animator anim6;


    void Start()
    {
        cow6Sound = GetComponent<AudioSource>();
        anim6 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow6Sound.Play();
        anim6.SetBool("isStanding6", true);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        anim6.SetBool("isStanding6", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow6Sound.Stop();
    }

}

