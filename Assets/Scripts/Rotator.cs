using DG.Tweening;

public class Rotator : Changer
{
    protected override void Change()
    {
        transform.DORotate(ChangeValue, Duration).SetLoops(-1, LoopType.Incremental).SetEase(Ease.Linear);
    }
}