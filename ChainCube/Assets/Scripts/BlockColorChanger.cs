using UnityEngine;

public class BlockColorChanger : MonoBehaviour
{
    // Start is called before the first frame update

    private Renderer _renderer;
    private ColorManager _colorManager;
    private PointsHandler _blockBasicMechanics;

    private void Start()
    {
        SetColor();
    }

    public void SetColor()
    {
        _renderer = GetComponent<Renderer>();
        _blockBasicMechanics = GetComponent<PointsHandler>();
        _colorManager = GameObject.Find("ColorManager").GetComponent<ColorManager>();
        _renderer.material.color = _colorManager.GetMyColor(_blockBasicMechanics.GetBlockValue());
    }
}