using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class UI_Manager : MonoBehaviour
{
    public GameObject locomotion;

    public GameObject leftHandDirect, rightHandDirect;
    public GameObject leftHandRay, rightHandRay;
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

}
