using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    public State currentState;

    private void Update()
    {
        currentState.Tick(Time.deltaTime);
    }
}
