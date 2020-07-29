using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong4 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow4Sound;
    private Animator anim4;


    void Start()
    {
        cow4Sound = GetComponent<AudioSource>();
        anim4 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow4Sound.Play();
        anim4.SetBool("isStanding4", true);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        anim4.SetBool("isStanding4", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow4Sound.Stop();
    }

}
