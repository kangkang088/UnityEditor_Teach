using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Lesson21 : EditorWindow
{
    [MenuItem("UnityEditorExpand/Event")]
    private static void EventClass()
    {
        Lesson21 lesson21 = EditorWindow.GetWindow<Lesson21>();
        lesson21.Show();
    }
    void OnGUI()
    {

    }
}
