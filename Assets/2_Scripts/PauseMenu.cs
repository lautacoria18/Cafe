using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public HandPresence hand, handNoRay;

    public GameObject leftHandDirect, rightHandDirect;
    public GameObject leftHandRay, rightHandRay;
    public GameObject pause;

    public static PauseMenu instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
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
        leftHandDirect.SetActive(false);
        rightHandDirect.SetActive(false);
        leftHandRay.SetActive(true);
        rightHandRay.SetActive(true);
        hand.once = false;
        pause.SetActive(true);
    }
}
