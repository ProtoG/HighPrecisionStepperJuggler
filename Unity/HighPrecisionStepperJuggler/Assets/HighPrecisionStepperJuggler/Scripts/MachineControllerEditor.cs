﻿using UnityEditor;
using UnityEngine;

namespace HighPrecisionStepperJuggler
{
    [CustomEditor(typeof(MachineController))]
    public class MachineControllerEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            var script = (MachineController) target;
            
            if (GUILayout.Button("Go to height: 10", GUILayout.Width(200)))
            {
                script.SendSingleInstruction(new HLInstruction(0.01f, 0f, 0f, 1f));
            }

            if (GUILayout.Button("Go to origin", GUILayout.Width(200)))
            {
                script.GoToOrigin();
            }
        }
    }
}