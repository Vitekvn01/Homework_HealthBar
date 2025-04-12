using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private const int MaxCount = 100;
    private const int MinCount = 0;
    
    private int _count = MaxCount;
    
    public int Count
    {
        get
        {
            return _count;
        }
        private set
        {
            _count = value;
            OnChangeCountHealth?.Invoke(_count);
        }
    }

    public Action<int> OnChangeCountHealth;

    public void AddHealth(int count)
    {
        Count += count;

        if (Count > MaxCount) Count = MaxCount;
    }

    public void RemoveHealth(int count)
    {
        Count -= count;

        if (Count < MinCount) Count = MinCount;
    }
}
