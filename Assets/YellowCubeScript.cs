using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowCubeScript : BaseCubeState
{
    public override CubeScript _cube { get; }
    public YellowCubeScript(CubeScript cube)
    {
        _cube = cube;
    }

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
