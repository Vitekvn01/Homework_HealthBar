using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AddHealthButton : MonoBehaviour
{
    private const string Symbol = "+"; 
    
    [SerializeField] private Health _health;
    
    [SerializeField] private int _count;

    private Button _button;
    
    private TextMeshProUGUI _text;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeAddHealth);

        _text = GetComponentInChildren<TextMeshProUGUI>();
        _text.text = $"{Symbol}{_count}";
    }

    private void ChangeAddHealth()
    {
        _health.AddHealth(_count);
    }
}
