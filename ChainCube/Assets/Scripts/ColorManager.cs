using UnityEngine;

public class ColorManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] blockColor;

    public Color GetMyColor(int blockValue)
    {
        for (int i = 0; i < blockColor.Length; i++)
        {
            if (blockValue == (int) Mathf.Pow(2, i))
                return blockColor[i - 1];
        }


        return Color.white;
    }
}