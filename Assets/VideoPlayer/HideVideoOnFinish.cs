using UnityEngine;
using UnityEngine.Video;

public class HideVideoOnFinish : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private void Start()
    {
        // Get the VideoPlayer component from the same GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        // Add an event listener for when the video finishes
        videoPlayer.loopPointReached += VideoFinished;
    }

    private void VideoFinished(VideoPlayer vp)
    {
        // The video has finished playing, disable or hide the GameObject
        videoPlayer.Stop(); // Or use SetActive(false) to hide it
    }
}