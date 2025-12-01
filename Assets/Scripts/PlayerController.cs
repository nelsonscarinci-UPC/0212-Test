using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private float _speed;
    [SerializeField] private int _health;
    [SerializeField] private UIController _uiController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue inputValue)
    {
        var direction = inputValue.Get<Vector2>();
        _rb.linearVelocity = direction * _speed;
    }

    public void TakeDamage()
    {
        _uiController.UpdateUI(_health);
    }
}
