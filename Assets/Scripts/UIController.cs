using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private TextMeshProUGUI _healthTxt;
    void Start()
    {
        _healthTxt = GetComponent<TextMeshProUGUI>();
    }


    public void UpdateUI(int health)
    {
        _healthTxt.text = $"Health: {health}";
    }
}
