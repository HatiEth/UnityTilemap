using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(Tilemap))]
public class TilemapEditor : Editor {

    Tilemap map;

    void OnEnable()
    {
        Tools.current = Tool.None;
        map = target as Tilemap;
    }

    public void OnSceneGUI()
    {
        // EventHandling
    }

    [DrawGizmo(GizmoType.NonSelected|GizmoType.Active)]
    public static void OnDrawGizmo(Tilemap map, GizmoType type)
    {

    }

}
