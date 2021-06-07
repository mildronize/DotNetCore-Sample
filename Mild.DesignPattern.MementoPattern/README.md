# Mild.DesignPattern.MementoPattern

Demonstrate Memento Pattern: It able to undo and redo a state of objects.

<!-- more -->

## Run

```
dotnet run
```

See the result in the console

## Example

```c#
// Program.cs (main)
var stateManager = new CareTaker<Editor>();
var editor = new Editor("T1", "Text 1", 14, "TH SarabunPSK");
Console.WriteLine(editor);
var state1 = editor.CreateState();
stateManager.PushMemento(state1);
editor = new Editor("T2", "Text 2", 15, "TH SarabunPSK");
Console.WriteLine(editor);
stateManager.PushMemento(editor.CreateState());
editor = new Editor("T3", "Text 3", 16, "TH Sarabun New");
Console.WriteLine(editor);
var undoState = stateManager.Undo();
editor.RestoreState(undoState);
Console.WriteLine($"Undo - {editor}");
editor.RestoreState(stateManager.Undo());
Console.WriteLine($"Undo - {editor}");
editor.RestoreState(stateManager.Redo());
Console.WriteLine($"Undo - {editor}");
editor = new Editor("T3", "Text 3", 16, "TH Sarabun New");
Console.WriteLine(editor);
stateManager.PushMemento(editor.CreateState());
editor = new Editor("T4", "Text 4", 17, "TH Sarabun New");
Console.WriteLine(editor);
editor.RestoreState(stateManager.Undo());
Console.WriteLine($"Undo - {editor}");
```

## Output

```c#
T1 Text 1 TH SarabunPSK 14
T2 Text 2 TH SarabunPSK 15
T3 Text 3 TH Sarabun New 16
Undo - T2 Text 2 TH SarabunPSK 15
Undo - T1 Text 1 TH SarabunPSK 14
Undo - T1 Text 1 TH SarabunPSK 14
T3 Text 3 TH Sarabun New 16
T4 Text 4 TH Sarabun New 17
Undo - T3 Text 3 TH Sarabun New 16
```

# Ref
- [สอน C# Design Patterns : Memento Pattern By ดร.อุทาน บูรณศักดิ์ศรี](https://www.youtube.com/watch?v=b1BkHlmH8Q0&list=PLUqNhFEQnG_OTpewdbOXCCbFBb_hT_FpZ) - Step by step teaching Thai Language [[Source Code](https://github.com/utarn/csharp-design-pattern-memento/tree/ce5e8821e707e1286a038102179edc2d5a0fd446)]
- Design Pattern Original Book : https://www.amazon.com/Design-Patterns-Object-Oriented-Addison-Wesley-Professional-ebook/dp/B000SEIBB8
- Memento Pattern : https://en.wikipedia.org/wiki/Memento_pattern