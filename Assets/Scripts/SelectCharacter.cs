using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    [SerializeField] private List<CharacterBase> availableCharacters;

    // ENCAPSULATION
    // We're using a property to control the access to the selected character
    // and make sure it is always a valid character,also we're using an event to notify the subscribers
    // when the selected character changes.
    private CharacterBase _selectedCharacter;

    public CharacterBase SelectedCharacter
    {
        get { return _selectedCharacter; }
        set
        {
            if (availableCharacters.Contains(value))
            {
                _selectedCharacter = value;
                OnSelectedCharacter?.Invoke(_selectedCharacter);
            }
        }
    }

    public Action<CharacterBase> OnSelectedCharacter;

    
    void Start()
    {
        // PreSelects the first character in the list..
        if (availableCharacters?.Count > 0)
            SelectedCharacter = availableCharacters[0];
    }

    void Update()
    {
        HandleCharacterSelection();
    }

    private void HandleCharacterSelection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                var character = hit.collider.gameObject.GetComponent<CharacterBase>();

                if (character != null)
                {
                    SelectedCharacter = character;
                }
            }
        }
    }
}