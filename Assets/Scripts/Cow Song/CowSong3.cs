using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong3 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow3Sound;
    private Animator anim3;


    void Start()
    {
        cow3Sound = GetComponent<AudioSource>();
        anim3 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow3Sound.Play();
        anim3.SetBool("isStanding3", true);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        anim3.SetBool("isStanding3", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow3Sound.Stop();
    }

}
