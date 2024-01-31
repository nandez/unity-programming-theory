using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;

// INHERITANCE
public class DisplayBiography : DisplayBase
{
    [SerializeField] private TMP_Text biographyLabel;

    // POLYMORPHISM
    // Here we override the LoadInfo method from the base class
    // to load the biography in the text component.
    protected override void LoadInfo(CharacterBase character)
    {
        biographyLabel.text = character.Biography;
    }
}