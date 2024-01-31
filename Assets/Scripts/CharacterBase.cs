using UnityEngine;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private int _strength;
    [SerializeField] private int _dexterity;
    [SerializeField] private int _intelligence;
    [SerializeField] private int _health;
    [SerializeField] private int _damage;
    [SerializeField] private string _biography;

    public string Name => _name;
    public int Strength => _strength;
    public int Dexterity => _dexterity;
    public int Intelligence => _intelligence;
    public int Health => _health;
    public int Damage => _damage;
    public string Biography => _biography;

    public abstract string Greet();
}