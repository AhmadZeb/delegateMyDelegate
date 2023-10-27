namespace delegateMyDelegate
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            delegateclass delegateclass = new delegateclass();
            delegateclass.MethodA(CallBackFunc.FuncCallBack);
        }
        

    }
}