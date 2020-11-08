using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCubeScript : BaseCubeState
{
    //public override Material Material { get; }

    public RedCubeScript(CubeScript cube)
    {
        _cube = cube;
        //Material = Resources.Load<Material>("Red");
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
