using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
    public enum KeyboardType { TwoD, ThreeD, Isometric }
    [Tooltip("Would you like key names turned on?")] public bool keyNames;
}
