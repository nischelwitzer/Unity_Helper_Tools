using UnityEngine;

public class TextAssetLoader : MonoBehaviour
{

    [SerializeField] private TextAsset myText;

    void Start()
    {
        string[] lines = myText.text.Split(new[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.None);

        foreach (string line in lines)
        {
            string partlist = null;
            string[] parts = line.Split(' ', '\t');
            foreach (string part in parts)
            { 
                partlist += "<b><color=white>"+part+"</color></b>" + " <> ";
            }
            Debug.Log($"Line has <color=yellow><b>{parts.Length}</b></color> parts: "+ partlist);
        }
    }
}
