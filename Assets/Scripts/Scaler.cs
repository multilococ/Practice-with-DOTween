using DG.Tweening;

public class Scaler : Changer
{
    protected override void Change()
    {
        transform.DOScale(ChangeValue, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
