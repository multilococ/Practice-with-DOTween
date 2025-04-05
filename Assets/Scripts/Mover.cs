using DG.Tweening;

public class Mover : Changer
{
    protected override void Change()
    {
        transform.DOMove(ChangeValue, Duration).SetLoops(-1, LoopType.Yoyo);
    }
}
