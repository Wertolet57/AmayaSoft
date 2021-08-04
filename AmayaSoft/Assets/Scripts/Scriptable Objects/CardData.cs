using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    [SerializeField] private string _identifier;
    [SerializeField] private Sprite _sprite;

    public string Identifier { get { return _identifier; } }
    public Sprite Sprite { get { return _sprite; } }

}
