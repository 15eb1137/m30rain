using UnityEngine;
using UnityEngine.InputSystem;

public class ActionButtonTest : MonoBehaviour
{
    void Update()
    {
        var current = Keyboard.current;

        if (current == null) { return; }

        if (current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Space key was pressed.");
        }
    }
}
