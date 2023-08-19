
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class UI_Manager : MonoBehaviour
{
    public GameObject locomotion;

    public GameObject leftHandDirect, rightHandDirect;
    public GameObject leftHandRay, rightHandRay;
    public Slider sliderVolume;
    public GameObject creditsPanel;
    private void Awake()
    {
        Time.timeScale = 0;
        locomotion.GetComponent<ContinuousMoveProviderBase>().enabled = false;
        leftHandDirect.SetActive(false);
        rightHandDirect.SetActive(false);
        leftHandRay.SetActive(true);
        rightHandRay.SetActive(true);
    }

    public void  StartGame() {

        Time.timeScale = 1;
        locomotion.GetComponent<ContinuousMoveProviderBase>().enabled = true;
        leftHandDirect.SetActive(true);
        rightHandDirect.SetActive(true);
        leftHandRay.SetActive(false);
        rightHandRay.SetActive(false);
        gameObject.SetActive(false);
    }

    public void RestartGame() {

        SceneManager.LoadScene("SampleScene");
    
    }

    public void OpenCreditsPanel() {

        if (!creditsPanel.activeSelf)
        {

            creditsPanel.SetActive(true);

        }
        else {

            creditsPanel.SetActive(false);
        }
    
    }

    public void QuitGame() {


        Application.Quit();
    }

    private void Update()
    {
        //sliderVolume.value = settings.audioVolume;
        //settings.value = sliderVolume.audioVolume;
    }

}
