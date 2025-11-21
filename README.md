# Unity_Helper_Tools

## Parameters in C# Files

```
[DefaultExecutionOrder(-100)]
[RequireComponent(typeof(Rigidbody))]
```

## Text Assets Parsing

* StreamingAssets folder (case-sensitive)
* Resources Resources.Load 

## Text Assets Loading

```
[Header("Datei-Einstellungen")]
[Tooltip("Pfad zur TXT-Datei (Textformat, z. B. alex.txt)")]
public string myFile = "Assets/alex.txt";
[SerializeField] private TextAsset myText;
```
```
TextAsset file = Resources.Load("text/config") as TextAsset; // in Assets/Resources/text/config.txt
string content = file.toString();
```

## Text Assets Parsing

```
string[] lines = txtFile.text.Split(
  new[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.None);

foreach (var line in lines)
{
    var parts = line.Split(' ', '\t');
}
```






