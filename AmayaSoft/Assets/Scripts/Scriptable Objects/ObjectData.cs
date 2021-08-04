using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New ObjectData", menuName = "Object Data", order = 10)]
public class ObjectData : ScriptableObject
{
    [SerializeField] private CardData[] _cardData;
    public CardData[] CardDatas { get { return _cardData; } }
}
