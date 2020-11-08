using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateManager : MonoBehaviour
{
    [SerializeField] private Button _redButton;
    [SerializeField] private Button _yellowButton;
    [SerializeField] private Button _greenButton;

    [SerializeField] private GameObject _cube;
    private void Start()
    {
        _redButton.onClick.AddListener(SetStateRed);
        _yellowButton.onClick.AddListener(SetStateYellow);
        _greenButton.onClick.AddListener(SetStateGreen);
    }

    private void SetStateGreen()
    {
        _cube.GetComponent<CubeScript>().SetState(CubeState.Green);
    }

    private void SetStateYellow()
    {
        _cube.GetComponent<CubeScript>().SetState(CubeState.Yellow);

    }

    private void SetStateRed()
    {
        _cube.GetComponent<CubeScript>().SetState(CubeState.Red);

    }

}
