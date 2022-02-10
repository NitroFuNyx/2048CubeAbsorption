using UnityEngine;
using Random = UnityEngine.Random;

public class PointsHandler : MonoBehaviour
{
    private int _blockValue = 2;

    private void Awake()
    {
        _blockValue = (int) Mathf.Pow(2, Random.Range(1, 4));
    }

    public int GetBlockValue()
    {
        return _blockValue;
    }

    public void IncreaseValueBy2()
    {
        _blockValue *= 2;
    }
}