using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class NameValidation : MonoBehaviour
{
  [SerializeField] TMP_InputField nameInputField;

	private void Update() {
		if(nameInputField.text == "") {
			transform.GetComponent<Button>().interactable = false;
		} else {
			transform.GetComponent<Button>().interactable = true;
		}
	} 
}
