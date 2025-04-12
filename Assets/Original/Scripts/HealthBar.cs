using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
   [SerializeField] private Slider _slider;
   [SerializeField] private Health _health;

   [SerializeField] private float _speedFill;
   
   private int _fillHealthBar;
   
   private void Start()
   {
      _slider.value = _health.Count;
      _fillHealthBar = _health.Count;
      
      _health.OnChangeCountHealth += UpdateHealthBar;
   }

   private void Update()
   {
      _slider.value = Mathf.MoveTowards(_slider.value, _fillHealthBar, _speedFill * Time.deltaTime);
   }

   private void UpdateHealthBar(int count)
   {
      _fillHealthBar = count;
   }

}
