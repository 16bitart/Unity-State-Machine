using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public abstract class BaseCubeState
{
    //public abstract Material Material { get; }
    public abstract CubeScript _cube { get; }
    public abstract void EnterState();
    public abstract void Update();
    public abstract void OnCollisionEnter();
}
