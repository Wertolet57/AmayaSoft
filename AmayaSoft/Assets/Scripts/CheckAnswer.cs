using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CheckAnswer : MonoBehaviour
{
    [SerializeField] private GameObject _partSys;
    private NewLevel _newLevel;

    private void Start()
    {
        _newLevel = FindObjectOfType<NewLevel>();
    }
    private void OnMouseDown()
    {
        if (_newLevel.IsGame)
        {
            if (_newLevel.Answer == gameObject.name)
            {
                transform.GetChild(0).DOPunchScale(Vector2.one, 1f, 1, 2f);
                Instantiate(_partSys);
                Invoke("Spawn", 1f);
            }
            else
            {
                transform.GetChild(0).DOPunchPosition(Vector2.left * 0.25f, 1f, 10, 2, false);
            }
        }
    }
    private void Spawn()
    {
        _newLevel.Spawn();
    }
}
