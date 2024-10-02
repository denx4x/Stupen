using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonController : MonoBehaviour {

    public Button Submit;
    public TMP_InputField Input;
    public TMP_Text UIText;

    // Start is called before the first frame update
    void Start() {
        Submit.onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick() {
        UIText.text = Input.text;
        UIText.fontSize += 1;
    }

}
