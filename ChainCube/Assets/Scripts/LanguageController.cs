using TMPro;
using UnityEngine;

public class LanguageController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI textMeshPro;
    [SerializeField] private JsonFileWriter languages;

    public void RuChoose()
    {
        languages.LoadResourceTextFile();
        textMeshPro.text = languages.data.playBtn.ru;
    }

    public void EnChoose()
    {
        languages.LoadResourceTextFile();
        textMeshPro.text = languages.data.playBtn.eng;
    }
}