using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FallingWater : MonoBehaviour
{

    public float lerpSpeed;
    Vector3 start = Vector3.zero;
    Vector3 end = new Vector3(0.04f, 0.1834807f, 0.02f);

    Vector3 finalPosition = new Vector3(-0.11185202f, 1.83669996f, 0.906799972f);

    Vector3 endDispenserScale = new Vector3(0.0399999991f, 0.000823202776f, 0.0199999996f);
    Vector3 endDispenserPosition = new Vector3(-0.11185202f, 1.65409005f, 0.906799972f);

    public bool startWater, endWater;

    public WaterIntoMoka waterMoka;

    public bool newWaterOn;
    public ParticleSystem coffee;


    public void StartToVERT(bool cond) {
        newWaterOn = cond;
        
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag == "Moka")
        {
            Moka.instance.waterIn = true;
            waterMoka.startDisp = true;

        }
        else {

            waterMoka.startDisp = false;
        }
            Debug.Log(other.transform.tag);
     
    }


    // Update is called once per frame
    void Update()
    {
        if (newWaterOn) {

            coffee.enableEmission = true;
            Debug.Log("gira");
        }
        else
        {

            coffee.enableEmission = false;
            Debug.Log("No gira");


        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "MokaTriggerCollider")
        {

            waterMoka.startDisp = true;
            Debug.Log("TOCO COLLIDER");
        }
    }
}
