using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
public class DisplayGreeting : DisplayBase
{
    [SerializeField] private GameObject _greetingPanel;
    [SerializeField] private TMP_Text _greetingText;
    [SerializeField] private int _delay = 5;

    // POLYMORPHISM
    // Here we override the LoadInfo method from the base class
    // to activate the greeting panel, load the greeting of the character
    // and hide the greeting panel after a few seconds.
    protected override void LoadInfo(CharacterBase character)
    {
        _greetingPanel.SetActive(true);
        _greetingText.text = character.Greet();
        StartCoroutine(Dismiss(_delay));
    }

    private IEnumerator Dismiss(int delay)
    {
        yield return new WaitForSeconds(delay);
        _greetingPanel.SetActive(false);
    }
}