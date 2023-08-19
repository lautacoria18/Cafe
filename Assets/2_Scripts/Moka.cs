using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moka : ObjectGrabable
{

    public static Moka instance;

    public float timeTouchingFire;
    public bool touchFire;

    public float timeToStart;

    public Animator side1, side2, liquid;
    public bool animationDone;

    public float degrees, degrees2;
    public ParticleSystem coffee;


 

    private void Awake()
    {
        base.Awake();
        instance = this;
        coffee.enableEmission = false;
    }

    public bool waterIn, filterIn, coffeeIn, jarraIn, liquidCoffeeIn;



    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hornalla") {

            touchFire = true;
    
            Debug.Log("tocafuego");
            Debug.Log(timeTouchingFire);
        
        }
    }
    private void Update()
    {
        if (liquidCoffeeIn)
        {
            if (Vector3.Angle(Vector3.down, transform.right) <= degrees && Vector3.Angle(Vector3.down, transform.right) >= degrees2)
            {

                coffee.enableEmission = true;
                Debug.Log("gira");
            }
            else
            {

                coffee.enableEmission = false;
                Debug.Log("No gira");
            }
        }

    
            if (touchFire)
            {
            if (jarraIn)
            {
                timeTouchingFire += Time.deltaTime % 60;
            }
            else {

                Debug.Log("Falta la jarra");
            }
            }
        
       

            if (timeTouchingFire > timeToStart && !animationDone)
            {

                side1.gameObject.SetActive(true);
                side2.gameObject.SetActive(true);
                liquid.gameObject.SetActive(true);

                side1.SetTrigger("Start");
                side2.SetTrigger("Start");
                liquid.SetTrigger("Start");
                StartCoroutine(StopSides());
                animationDone = true;
                liquidCoffeeIn = true;
            }
        
    }
    IEnumerator StopSides() {

        yield return new WaitForSeconds(21F);
        side1.gameObject.SetActive(false);
        side2.gameObject.SetActive(false);

    }

    
}
