# Unity_Helper_Tools

## Parameters

```
[DefaultExecutionOrder(-100)]

```

## Text Assets

```
TextAsset file = Resources.Load("MyJSONFolder/config") as TextAsset;
string content = file.toString();
```

```
string[] lines = txtFile.text.Split(
  new[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.None);

foreach (var line in lines)
{
    var parts = line.Split(' ', '\t');
}
```

```
[Header("Datei-Einstellungen")]
[Tooltip("Pfad zur TXT-Datei (Textformat, z. B. alex.txt)")]
public string myFile = "Assets/alex.txt";
```
