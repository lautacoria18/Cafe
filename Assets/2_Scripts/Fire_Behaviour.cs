using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fire_Behaviour : MonoBehaviour
{

    public GameObject[] flame;
    public int turn;
    public bool isTurned;

    

    public void StartFire() {

        if (!isTurned)
        {
            StartCoroutine(WaitForLoop());
        }
        else {

            for (int i = 0; i < flame.Length; i++)
            {

                flame[i].SetActive(false);
            }
            isTurned = false;

            GetComponent<BoxCollider>().enabled = false;
        }

    }

    private void Update()
    {
       
    }
    public void SetFire() {


  
    
    
    }

    public IEnumerator WaitForLoop() {

        bool end = true;

        for (int i = 0; i < flame.Length; i++)
        {

            end =  end && flame[i].activeSelf;
        }
        if (end)
        {
            GetComponent<BoxCollider>().enabled = true;
            isTurned = true;
            turn = 0;

        }
        else
        {

            yield return new WaitForSeconds(0.01f);
            flame[turn].SetActive(true);
            turn++;
            StartCoroutine(WaitForLoop());
        }
    }
}
