using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionInstantiator : MonoBehaviour {


    public Transform prefab;
    public int minionCount;
    public float delay;

    private int counter;
    private Timer timer;

	// Use this for initialization
	void Start ()
    {
        timer = new Timer(delay, delay);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        timer.Time += Time.deltaTime;
        if (timer.Expired == true && counter < minionCount)
        {

            Instantiate(prefab, transform.position, transform.rotation);
            timer.Time -= delay;
            ++counter;
        }
		
	}
}
