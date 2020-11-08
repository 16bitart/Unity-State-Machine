using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubeScript : BaseCubeState
{
    //public override Material Material { get; }

    public GreenCubeScript(CubeScript cube)
    {
        _cube = cube;
    }

    public override CubeScript _cube { get; }

    public override void EnterState()
    {
        _cube.SetColor(Resources.Load<Material>("Green"));
    }

    public override void Update()
    {
    }

    public override void OnCollisionEnter()
    {
    }
}
