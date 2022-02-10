using UnityEngine;

public class ScoreContainer : MonoBehaviour
{
    private TextSetter _textSetter;
    private long _amountOfScore;

    private void Start()
    {
        _textSetter = GetComponent<TextSetter>();
    }

    public long AmountOfScore
    {
        get => _amountOfScore;
        set
        {
            _amountOfScore = value;
            _textSetter.SetTheText(_amountOfScore);
        }
    }
}