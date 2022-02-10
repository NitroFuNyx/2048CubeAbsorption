using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using Vector3 = UnityEngine.Vector3;


public class MergeBlock : MonoBehaviour
{
    // Start is called before the first frame update
    private PointsHandler _pointsHandler;
    private TextController _textController;
    private BlockColorChanger _blockColorChanger;
    private Rigidbody _rigidbody;
    private ScoreContainer _scoreContainer;

    private void Awake()
    {
        _pointsHandler = gameObject.GetComponent<PointsHandler>();
        _textController = gameObject.GetComponent<TextController>();
        _blockColorChanger = gameObject.GetComponent<BlockColorChanger>();
        _rigidbody = gameObject.GetComponent<Rigidbody>();
        _scoreContainer = GameObject.Find("Score").GetComponent<ScoreContainer>();
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.GetComponent<PointsHandler>())
        {
            int otherPoints = other.gameObject.GetComponent<PointsHandler>().GetBlockValue();
            if (_pointsHandler.GetBlockValue() == otherPoints)
            {
                _pointsHandler.IncreaseValueBy2();
                _textController.SetTheText();
                _blockColorChanger.SetColor();
                Destroy(other.gameObject);
                _rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
                _scoreContainer.AmountOfScore += _pointsHandler.GetBlockValue();
            }
        }
    }
}