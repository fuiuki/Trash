using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPickup : MonoBehaviour {

    private Timer timer;
    public float pickupTimeInSeconds = 0.5f;
    public TempPointSystem pointSystem;
    private bool timerOn = false;
    public string playerTag = "Player";

	// Use this for initialization
	void Start()
    {
        timer = new Timer(pickupTimeInSeconds, 0);
    }

    void Update()
    {


        if (timerOn)
        {

            timer.Time += Time.deltaTime;
            if (timer.Expired == true)
            {
                Debug.Log("Picked");
                pointSystem.FillMeter(1);
                Destroy (gameObject);
            }

        }
    }
	

    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.gameObject.tag == playerTag)
        {
            timerOn = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == playerTag)
        {
            timer.Time = 0;
            timerOn = false;
        }
    }
}
