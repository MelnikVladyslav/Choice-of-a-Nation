using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Menu.Settings.Sounds
{
    public class SoundManager : MonoBehaviour
    {
        public AudioSource audioSource;
        public AudioClip[] playlist;
        public bool isPlayPlaylist = false;
        private int currentTrackIndex = 0;

        public void getVolume(Slider sl)
        {
            if (sl.value == 0)
            {
                PlayerPrefs.SetFloat("volume", 0.5f);
            }
            else
            {
                PlayerPrefs.SetFloat("volume", sl.value);
            }
        }

        void Start()
        {
            if (playlist.Length > 0)
            {
                // Відтворюємо перший трек
                PlayTrack(currentTrackIndex);
            }
        }

        void Update()
        {
            if (isPlayPlaylist)
            {
                // Перевіряємо, чи закінчився поточний трек
                if (!audioSource.isPlaying && playlist.Length > 0)
                {
                    NextTrack();
                }
            }
        }

        private void PlayTrack(int index)
        {
            if (index >= 0 && index < playlist.Length)
            {
                audioSource.clip = playlist[index];
                audioSource.Play();
                Debug.Log($"Now playing: {playlist[index].name}");
            }
        }

        private void NextTrack()
        {
            // Перемикаємо на наступний трек
            currentTrackIndex++;
            if (currentTrackIndex >= playlist.Length)
            {
                // Якщо досягли кінця списку, починаємо спочатку
                currentTrackIndex = 0;
            }
            PlayTrack(currentTrackIndex);
        }
    }
}