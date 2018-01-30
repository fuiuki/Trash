using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShooterPattern : MonoBehaviour {

    //public abstract void Start();

    public abstract void Shoot(GameObject shooterGameObject);

    //private abstract void ShootPattern();

    public abstract void Reset();
}
