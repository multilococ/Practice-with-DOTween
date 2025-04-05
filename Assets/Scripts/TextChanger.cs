using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        Change();
    }

    private void Change() 
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("������ ������", _duration));
        sequence.Append(_text.DOText(_text.text + " ���������� � ������", _duration));
        sequence.Append(_text.DOText("���������� �����", _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1,LoopType.Restart);
        sequence.SetDelay(_delay);
    }
}
