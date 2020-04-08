using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Kawaine.Keyngine
{
    public class Keyboard : MonoBehaviour
    {
        [OnChangedCall("UpdateKeyNames")]public bool showKeyNames = false;

        [HideIf("showKeyNames", false, ComparisonType.Equals), OnChangedCall("UpdateKeyNames")] public bool showSecondaryKeyNames = false;

        public List<Key> keyboard;

        public void UpdateKeyNames()
        {
            if(showKeyNames && showSecondaryKeyNames)
            {
                for (int i = 0; i < keyboard.Count; i++)
                {
                    keyboard[i].GetComponent<Key>().SetKeyName(true);
                }
            }
            else if(showKeyNames && !showSecondaryKeyNames)
            {
                for (int i = 0; i < keyboard.Count; i++)
                {
                    keyboard[i].GetComponent<PrimaryKey>().SetKeyName(true);
                    keyboard[i].GetComponent<SecondaryKey>().SetKeyName(false);
                }
            }
            else
            {
                for (int i = 0; i < keyboard.Count; i++)
                {
                    keyboard[i].GetComponent<Key>().SetKeyName(false);
                }
            }
        }
    }
}

