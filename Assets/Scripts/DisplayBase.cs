using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DisplayBase : MonoBehaviour
{
    void Start()
    {
        SubscribeToCharacterSelection();
    }

    // ABSTRACTION
    // This method is abstract and must be implemented by the derived classes.
    // It will be called when a character is selected, so derived classes can load the info
    // of the selected character as they fit.
    protected abstract void LoadInfo(CharacterBase character);

    private void SubscribeToCharacterSelection()
    {   
        var selectCharacterObj = FindObjectOfType<SelectCharacter>();
        if (selectCharacterObj != null)
        {
            selectCharacterObj.OnSelectedCharacter += LoadInfo;

            if (selectCharacterObj.SelectedCharacter != null)
                LoadInfo(selectCharacterObj.SelectedCharacter);
        }
    }
}
