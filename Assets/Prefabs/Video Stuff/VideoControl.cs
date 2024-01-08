using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;

namespace Prefabs.Video_Stuff
{
    public class VideoControl : MonoBehaviour
    {
        private VideoPlayer _player;

        [Tooltip("Video canvas")]
        public GameObject containerObject;
        
        public VideoClip clip;

        public void Play()
        {
            containerObject.SetActive(true);
            if (_player == null)
            {
                _player = containerObject.GetComponent<VideoPlayer>();
            }
            
            _player.clip = clip;
            _player.loopPointReached += Stop;
            _player.Play();
        }

        public void Stop(VideoPlayer p)
        {
            containerObject.SetActive(false);
        }
        
        public void Stop()
        {
            _player.Stop();
            containerObject.SetActive(false);
        }
    }
}
