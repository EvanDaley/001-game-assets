using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAttempt1 : MonoBehaviour
{
    private Dropdown _dropdown;
    private string _dropdownValue;

    void onEnable() {
        var uiDocument = GetComponent<UIDocument>();
        _dropdown = uiDocument.rootVisualElement.Q("dropdown") as Dropdown;
        _dropdown.RegisterCallback<ChangeEvent<string>>(DropdownChangeEvent);


    }

    void onDisable() {

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
