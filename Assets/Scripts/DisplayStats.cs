using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayStats : DisplayBase
{
    [SerializeField] private TMP_Text nameLabel;
    [SerializeField] private TMP_Text strengthLabel;
    [SerializeField] private TMP_Text dexterityLabel;
    [SerializeField] private TMP_Text intelligenceLabel;
    [SerializeField] private TMP_Text healthLabel;
    [SerializeField] private TMP_Text damageLabel;


    protected override void LoadInfo(CharacterBase character)
    {
        nameLabel.text = $"Name: {character?.Name}";
        strengthLabel.text = $"Strength: {character?.Strength}";
        dexterityLabel.text = $"Dexterity: {character?.Dexterity}";
        intelligenceLabel.text = $"Intelligence: {character?.Intelligence}";
        healthLabel.text = $"Health: {character?.Health}";
        damageLabel.text = $"Damage: {character?.Damage}";
    }
}