using UnityEngine;
using UnityEngine.InputSystem;

public class LeftStickTest : MonoBehaviour
{
    private void Update()
    {
        var current = Gamepad.current;

        if (current == null)
            return;

        var leftStickValue = current.leftStick.ReadValue();
        Debug.Log($"移動量：{leftStickValue}");
    }
}