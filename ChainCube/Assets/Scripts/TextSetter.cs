using TMPro;
using UnityEngine;

public class TextSetter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI textMeshPro;
    
    public void SetTheText(long score)
    {
        textMeshPro.text = score.ToString();
    }
}