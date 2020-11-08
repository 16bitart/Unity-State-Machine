using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CubeState
{
    Green,
    Yellow,
    Red
}

/// <summary>
/// The Context for our Cube State Machine.
/// </summary>
public class CubeScript : MonoBehaviour
{
    [SerializeField] public Renderer Renderer { get; private set; }
    [SerializeField] private BaseCubeState _currentState;

    private GreenCubeScript GreenState;
    private YellowCubeScript YellowState;
    private RedCubeScript RedState;

    public void SetState(CubeState state)
    {
        switch (state)
        {
            case CubeState.Green:
                _currentState = GreenState;
                break;
            case CubeState.Yellow:
                _currentState = YellowState;
                break;
            case CubeState.Red:
                _currentState = RedState;
                break;
        }
        _currentState.EnterState();
    }

    private void Awake()
    {
        Renderer = GetComponent<Renderer>();
        GreenState = new GreenCubeScript(this);
        YellowState = new YellowCubeScript(this);
        RedState = new RedCubeScript(this);
    }

    private void Update()
    {
        //_currentState.Update(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //_currentState.OnCollisionEnter(this);
    }

    public void SetColor(Material material)
    {
        Renderer.material = material;
    }
}
