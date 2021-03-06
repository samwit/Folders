﻿using UnityEngine;
using System.Collections;

namespace Rubycone.Folders {
    [ExecuteInEditMode]
    [DisallowMultipleComponent]
    public class Note : MonoBehaviour {
        [SerializeField]
        bool _resolveBeforeBuild;
        [SerializeField]
        string _text = string.Empty;

        public bool resolveBeforeBuild { get { return _resolveBeforeBuild; } }
        public string text { get { return _text; } }

        void Update() {
            hideFlags = HideFlags.DontSaveInBuild;
        }

        void OnDisable() {
            enabled = true;
        }
    }

    public static class NoteUtils {
        public static Note GetAsNote(this GameObject g) {
            if(g == null) {
                return null;
            }
            else {
                return g.GetComponent<Note>();
            }
        }
    }
}