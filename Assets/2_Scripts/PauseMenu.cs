using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public HandPresence hand, handNoRay;

    public GameObject leftHandDirect, rightHandDirect;
    public GameObject leftHandRay, rightHandRay;
    public GameObject pause;

    public AudioSource gameAudio;
    public static PauseMenu instance;
    public Slider sliderVolume;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;

        gameAudio = GameObject.Find("Start").GetComponent<AudioSource>();
        sliderVolume.value = gameAudio.volume;
    }

    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");

    }

    private void Update()
    {
        gameAudio.volume = sliderVolume.value;
        GameConstants.Instance.globalVolume = sliderVolume.value;
    }

    public void Resume()
    {
        leftHandDirect.SetActive(true);
        rightHandDirect.SetActive(true);
        leftHandRay.SetActive(false);
        rightHandRay.SetActive(false);
        //hand.isPressed = false;
        pause.SetActive(false);
        handNoRay.once = false;
    }

    public void Pause()
    {
        if (!GameObject.FindObjectOfType<UI_Manager>())
        {
            leftHandDirect.SetActive(false);
            rightHandDirect.SetActive(false);
            leftHandRay.SetActive(true);
            rightHandRay.SetActive(true);
            hand.once = false;
            pause.SetActive(true);
        }
    }
    public void QuitGame()
    {


        Application.Quit();
    }
}
