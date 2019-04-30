using UnityEditor;
using UnityEngine;

public class CircleEditor : EditorWindow
{
    public Circle circle = null;
    int ver = 3;
    int rad = 3;

    [MenuItem("Window/ Cirlce Editor")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CircleEditor));
    }

    void OnGUI()
    {
        circle = (Circle)EditorGUILayout.ObjectField("Circle", circle, typeof(Circle), true);
        if (circle != null)
        {
            ver = (int)EditorGUILayout.Slider("Vertexis", ver, 3, 500);
            circle.vertexes = ver;

            rad = (int)EditorGUILayout.Slider("Radius", rad, 0, 20);
            circle.radius = rad;

        }
    }

    void OnSCeneGUI()
    {
        //Circle t = (circle as Circle);
        rad = (int)Handles.RadiusHandle(Quaternion.identity, circle.transform.position, circle.radius);
        circle.radius = rad;
    }
}
