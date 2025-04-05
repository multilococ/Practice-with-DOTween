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
        
        sequence.Append(_text.DOText("Заменат текста", _duration));
        sequence.SetRelative();
        sequence.Append(_text.DOText(" дополнение к тексту", _duration));
        sequence.SetRelative(false);
        sequence.Append(_text.DOText("Взламываем текст", _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1,LoopType.Restart);
        sequence.SetDelay(_delay);
    }
}
