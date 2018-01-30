using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

	public State currentState;
	//public EnemyStats enemyStats;
	//public State remainState;

	[HideInInspector] public GameObject playerGameObject;
	[HideInInspector] public float stateTimeElapsed;

    //Set in inspector the 
    public Transform bulletSpawn;

	private float nextFire;

	// Use this for initialization
	void Awake ()
	{
        //If no spaww point has been set for the bullet
        if (bulletSpawn == null)
        {
            bulletSpawn = transform;
        }

		playerGameObject = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		currentState.UpdateState (this);
	}

    //Draws gizmo in inspector
	void OnDrawGizmos()
	{
		if (currentState != null)
		{
			Gizmos.color = currentState.sceneGizmoColor;
			Gizmos.DrawSphere (transform.position, 0.75f);		//Get radius from script
		}
	}

    //Changes state
	public void TransitionToState(State nextState)
	{
        //if (nextState != remainState)
        if (nextState != null)
        {
			currentState = nextState;
			//remainState = nextState;
			OnExitState ();
		}
	}

    //Check if time has expired
    //Use timer script instead???
	public bool CheckIfCountDownElapsed(float duration)
	{
		stateTimeElapsed += Time.deltaTime;
		return (stateTimeElapsed >= duration);
	}

    //When the state changes
	private void OnExitState()
	{
		stateTimeElapsed = 0;
	}
}
