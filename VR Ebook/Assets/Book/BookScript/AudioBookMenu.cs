using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioBookMenu : MonoBehaviour
{
    public GameObject showAudioBook;
    public GameObject notShowAudioBook;
    public GameObject audioBookMenuPanel;

    public GameObject playButton;
    public GameObject pauseButton;
    public GameObject unPauseButton;
    //public GameObject restartButton;

    void Start()
    {
        audioBookMenuPanel.SetActive(false);
        notShowAudioBook.SetActive(false);
    }

    public void ShowAudioBookMenu()
    {
        showAudioBook.SetActive(false);
        notShowAudioBook.SetActive(true);

        playButton.SetActive(true);
        audioBookMenuPanel.SetActive(true);
        pauseButton.SetActive(false);
        unPauseButton.SetActive(false);
        
    }
    public void HideAudioBookMenu()
    {
        audioBookMenuPanel.SetActive(false);

        showAudioBook.SetActive(true);
        notShowAudioBook.SetActive(false);
    }
    public void PlayAudioBook()
    {
        playButton.SetActive(false);
        pauseButton.SetActive(true);
        unPauseButton.SetActive(false);
    }
    public void PauseAudioBook()
    {
        playButton.SetActive(false);
        pauseButton.SetActive(false);
        unPauseButton.SetActive(true);
    }
    public void UnPauseAudioBook()
    {
        playButton.SetActive(false);
        pauseButton.SetActive(true);
        unPauseButton.SetActive(false);
    }
    public void RestartAudioBook()
    {
        PlayAudioBook();
    }

}
