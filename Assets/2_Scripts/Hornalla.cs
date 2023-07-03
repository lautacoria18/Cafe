using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hornalla : MonoBehaviour
{
    public Fire_Behaviour[] hornallas;
    
    public void SetAllFire() {

        for (int i = 0; i < hornallas.Length; i++)
        {

            hornallas[i].StartFire();
        }

    }
}
