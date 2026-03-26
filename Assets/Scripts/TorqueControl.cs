using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueControl : MonoBehaviour
{
    public float torquePower = 1f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            _rb.AddRelativeTorque(0, 0, torquePower);
        }
    }
}
