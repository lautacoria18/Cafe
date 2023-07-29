using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConstants : MonoBehaviour
{
    public static GameConstants Instance;
    public float globalVolume;

    void Awake()
    {
        if (Instance != null)
        {
            GameObject.Destroy(Instance);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad() {

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene("SampleScene");
    
    }

}
