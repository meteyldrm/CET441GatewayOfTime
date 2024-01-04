using UnityEngine;

namespace UI.Choice
{
    public class ChoiceController : MonoBehaviour
    {
        public GameObject choicePrefab;
        
        [SerializeField]
        private GameObject content;
        
        public void SetupChoice(string actionName)
        {
            var x = GameObject.Instantiate(choicePrefab, content.transform);
            x.GetComponent<ChoiceElement>().DoSetup(actionName);
        }

        public void DestroyChoices()
        {
            foreach (Transform x in content.transform)
            {
                GameObject.Destroy(x.gameObject);
            }
        }
    }
}
