using System.Collections;
using System.Collections.Generic;
using System.Xml;
using TMPro;
using UnityEngine;

public class DisplayBiography : DisplayBase
{
    [SerializeField] private TMP_Text additionalText;
    [SerializeField] private TMP_Text biographyLabel;

    protected override void LoadInfo(CharacterBase character)
    {
        biographyLabel.text = character.Biography;
    }
}