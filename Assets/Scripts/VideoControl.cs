using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;


public class VideoControl : MonoBehaviour
{



    Renderer outputRenderer;

    public VideoPlayer videoPlayer;
    public VideoClip videoToPlay;
    public VideoSource videoSource;

    public float playbackSpeed = 1f;




    void Start () {

        StartCoroutine(playVideo());


    }

    void Update ()

    {
       if(Input.touchCount > 0)
       {



           videoPlayer.playbackSpeed+=0.2f;
       }
        videoPlayer.playbackSpeed *= 0.99f;
    }

    IEnumerator playVideo()
    {


        videoPlayer = gameObject.AddComponent<VideoPlayer>();




        videoPlayer.source = VideoSource.VideoClip;



        //Set video To Play then prepare Audio to prevent Buffering
        videoPlayer.clip = videoToPlay;
        videoPlayer.Prepare();

        //Wait until video is prepared
        WaitForSeconds waitTime = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            Debug.Log("Preparing Video");

            yield return waitTime;

            break;
        }

        Debug.Log("Done Preparing Video");


        //Play Video
        videoPlayer.Play();



    }


}
