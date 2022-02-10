using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    [SerializeField] private List<Transform> texts = new List<Transform>();
    private PointsHandler _pointsHandler;

    private void Start()
    {
        SetTheText();
    }

    public void SetTheText()
    {
        _pointsHandler = GetComponent<PointsHandler>();
        foreach (Transform child in transform)
        {
            texts.Add(child);
            child.gameObject.GetComponent<TextMeshPro>().text = _pointsHandler.GetBlockValue().ToString();
        }
    }
}