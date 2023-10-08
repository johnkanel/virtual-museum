using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class PlayPause : MonoBehaviour
{
    private VideoPlayer video;
    bool isPlaying = false;

    // Start is called before the first frame update
    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
    }
    public void PlayVideo()
    {
        video.Play();
        isPlaying = true;
    }

    // Update is called once per frame
    public void PauseVideo()
    {
        video.Pause();
        isPlaying = false;
    }

    private void Update()
    {
        if (isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                PauseVideo();
        
        }
        else if (!isPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                PlayVideo();
        }

    }

}
