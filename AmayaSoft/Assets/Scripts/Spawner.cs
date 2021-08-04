using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _cell;
    [SerializeField] private ObjectData[] _objectData;
    public ObjectData[] ObjectData { get { return _objectData; } }
    private Dictionary<string,Sprite> _levelCards;
    private const int NewCell = 3;
    private List<GameObject> _cells = new List<GameObject>();
    private List<string> _answersAll = new List<string>();
    private string _answer;

    public string Spawn(int level)
    {
        _levelCards = new Dictionary<string, Sprite>();
        int index = Random.Range(0, _objectData.Length);
        for (int i = 0; i < _objectData[index].CardDatas.Length; i++)
            _levelCards.Add(_objectData[index].CardDatas[i].Identifier, _objectData[index].CardDatas[i].Sprite);
        List<string> answerNew = new List<string>();
        List<string> keys = new List<string>(_levelCards.Keys);
        int currentCount = _cells.Count + NewCell;
        float currentScale = _cell.transform.localScale.x;
        float xPos = -currentScale;
        float yPos = currentScale / 2 * (level - 1);

        for (int i = 0; i < currentCount; i++)
        {
            if (i>=_cells.Count)
            {
                GameObject cell = Instantiate(_cell);
                _cells.Add(cell);
            }
            index = Random.Range(0, keys.Count);
            _cells[i].transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = _levelCards[keys[index]];
            _cells[i].transform.name = keys[index];
            answerNew.Add(keys[index]);
            keys.Remove(keys[index]);
            _cells[i].transform.position = new Vector2(xPos, yPos);
            if (level == 1) _cells[i].transform.DOPunchScale(Vector2.one, 1f, 5, 2f);
            if (xPos < currentScale) xPos += currentScale;
            else xPos = -currentScale;
            if (xPos == -currentScale) yPos -= currentScale;
        }
        while (true)
        {
            _answer = answerNew[Random.Range(0, currentCount)];
            if (!_answersAll.Contains(_answer)) break;
        }
        _answersAll.Add(_answer);
        return _answer;
    }
}
