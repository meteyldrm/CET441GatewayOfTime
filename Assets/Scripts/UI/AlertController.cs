using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace UI {
    /// <summary>
    /// Alert Controller V3
    /// 
    /// V1 Action -> Ack
    /// V2 Action -> Op
    /// V2 Cancel -> NoOp
    /// 
    /// Future code references:
    /// V1 https://github.com/meteyldrm/Cet372UzaydaKaos/blob/master/Assets/Scripts/UI/AlertController.cs
    /// V2 https://github.com/Alierenkayhan/beready/blob/main/Assets/Scripts/UI/AlertController.cs
    /// </summary>
    public class AlertController : MonoBehaviour {
        [SerializeField] private GameObject alertTitle;
        [SerializeField] private GameObject alertBody;
        [SerializeField] private GameObject alertAck;
        
        [SerializeField] private GameObject alertOp;
        [SerializeField] private GameObject alertNoOp;
        
        private TextMeshProUGUI _alertTitleTmp;
        private TextMeshProUGUI _alertBodyTmp;
        private TextMeshProUGUI _alertAckTmp;
        
        private TextMeshProUGUI _alertOpTmp;
        private TextMeshProUGUI _alertNoOpTmp;

        private bool _configured;
        private UnityAction _opCallback;
        private UnityAction _noopCallback;

        private void OnEnable() {
            Configure();
        }

        public void Dismiss() {
            for (int i = 0; i < transform.childCount; i++) {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        private void Configure() {
            if (!_configured) {
                if (_alertAckTmp == null) _alertAckTmp = alertAck.GetComponent<TextMeshProUGUI>();
                if (_alertOpTmp == null) _alertOpTmp = alertOp.GetComponent<TextMeshProUGUI>();
                if (_alertNoOpTmp == null) _alertNoOpTmp = alertNoOp.GetComponent<TextMeshProUGUI>();
                if (_alertBodyTmp == null) _alertBodyTmp = alertBody.GetComponent<TextMeshProUGUI>();
                if (_alertTitleTmp == null) _alertTitleTmp = alertTitle.GetComponent<TextMeshProUGUI>();
                
                _configured = true;
            }
        }

        public void Alert(string title, string body, string action) {
            for (int i = 0; i < transform.childCount; i++) {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            Configure();
            alertOp.transform.parent.gameObject.SetActive(false);
            alertNoOp.transform.parent.gameObject.SetActive(false);
            
            _alertTitleTmp.text = title;
            _alertBodyTmp.text = body;
            _alertAckTmp.text = action;
        }
        
        public void Alert(string title, string body, string action, string cancel, UnityAction actionCallback = null, UnityAction cancelCallback = null) {
            for (int i = 0; i < transform.childCount; i++) {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            Configure();
            alertAck.transform.parent.gameObject.SetActive(false);
            
            _alertTitleTmp.text = title;
            _alertBodyTmp.text = body;
            _alertOpTmp.text = action;
            _alertNoOpTmp.text = cancel;
            
            _opCallback = actionCallback;
            _noopCallback = cancelCallback;
        }

        public void OpCallback()
        {
            _opCallback?.Invoke();
            Dismiss();
        }
        
        public void NoOpCallback()
        {
            _noopCallback?.Invoke();
            Dismiss();
        }
    }
}
