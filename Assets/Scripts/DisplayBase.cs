using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DisplayBase : MonoBehaviour
{
    void Start()
    {
        SubscribeToCharacterSelection();
    }


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
