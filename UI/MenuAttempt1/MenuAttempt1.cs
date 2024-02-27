using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuAttempt1 : MonoBehaviour
{
    private DropdownField _dropdown;
    private string _dropdownValue;

    void OnEnable() {
        Debug.Log("onEnable");

        var uiDocument = GetComponent<UIDocument>();
        _dropdown = uiDocument.rootVisualElement.Q("DropdownField1") as DropdownField;
        Debug.Log(_dropdown);
        _dropdown.RegisterCallback<ChangeEvent<string>>(dropdownChangeEvent);
    }

    void OnDisable() {
        Debug.Log("onDisable");

        _dropdown.UnregisterCallback<ChangeEvent<string>>(dropdownChangeEvent);
    }

    void dropdownChangeEvent(ChangeEvent<string> evt) {
        _dropdownValue = evt.newValue;
        Debug.Log($"Dropdown value changed to: {_dropdownValue}");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
