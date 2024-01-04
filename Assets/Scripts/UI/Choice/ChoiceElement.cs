using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Choice
{
    public class ChoiceElement : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI _tmp;
        [SerializeField]
        private Button _btn;
        private bool _configured = false;

        private SceneNavigator _nav;

        private void OnEnable()
        {
            Configure();
        }

        public void DoSetup(string text)
        {
            Configure();
            _tmp.text = text;
        }

        private void OnClick()
        {
            if(_nav == null) _nav = GameObject.FindWithTag("SceneNavigator").GetComponent<SceneNavigator>();
            
            _nav.OnUserChoice(transform.GetSiblingIndex());
        }

        void Configure()
        {
            if (!_configured)
            {
                _nav = GameObject.FindWithTag("SceneNavigator").GetComponent<SceneNavigator>();

                _btn.onClick.RemoveAllListeners();
                _btn.onClick.AddListener(OnClick);
                _configured = true;
            }
        }
    }
}
