using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewLevel : MonoBehaviour
{
    [SerializeField] private Text _findText;
    private int _currentLevel = 1;
    private Spawner _spawner;
    private EndPanel _endPanel;
    private string _answer;
    private bool _isGame = true;
    public bool IsGame { get { return _isGame; } }

    public string Answer { get { return _answer; } }

    private void Start()
    {
        _spawner = FindObjectOfType<Spawner>();
        _endPanel = FindObjectOfType<EndPanel>();
        Spawn();
    }

    public void Spawn()
    {
        if (_currentLevel == 4)
        {
            _isGame = false;
            _endPanel.PanelOn();
        }
        else
        {
            _answer = _spawner.Spawn(_currentLevel);
            _findText.text = $"Find {_answer}";
            _currentLevel++;
        }
    }
}
