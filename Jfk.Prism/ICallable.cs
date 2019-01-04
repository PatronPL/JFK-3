namespace Jfk.Prism
{
    public interface ICallable
    {
        int OR(int arg1, int arg2);
        int AND(int arg1, int arg2);
        int XOR(int arg1, int arg2);
        int MoveLeft(int arg1, int arg2);
        int MoveRight(int arg1, int arg2);
    }
}
