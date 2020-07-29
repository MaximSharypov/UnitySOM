using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CowSong7 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    private AudioSource cow7Sound;
    private Animator anim7;


    void Start()
    {
        cow7Sound = GetComponent<AudioSource>();
        anim7 = GetComponent<Animator>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {

        cow7Sound.Play();
        anim7.SetBool("isStanding7", true);
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        anim7.SetBool("isStanding7", false);
        Invoke("Stopsound", 0.2f);

    }

    void Stopsound()
    {
        cow7Sound.Stop();
    }

}
