using UnityEngine;
using UnityEngine.Events;
using TMPro;

namespace Kawaine.Keyngine
{
    public abstract class Key : MonoBehaviour
    {
        public KeyCode keyCode;

        [Header("References")]
        [ReadOnly]public bool keyNameActive = true;
        [HideIf("keyNameActive", false, ComparisonType.Equals)]
        public TextMeshPro keyName;
        [Tooltip("Is called the exact frame a key is pressed")] UnityEvent KeyDown;
        UnityEvent KeyBeingPressed;
        UnityEvent KeyUp;

        void Start()
        {
            if (KeyDown == null)
                KeyDown = new UnityEvent();
            if(Key == null)
            {

            }

            KeyDown.AddListener(Ping);
        }

        void Update()
        {
            if (Input.anyKeyDown && OnClick != null)
            {
                Input.Get
                OnClick.Invoke();
            }
        }

        public abstract void Ping();

        public void SetKeyName(bool b)
        {
            keyNameActive = b;
            if(keyNameActive)
            {
                keyName.gameObject.SetActive(true);
            }
            else
            {
                keyName.gameObject.SetActive(false);
            }
        }


    }
}