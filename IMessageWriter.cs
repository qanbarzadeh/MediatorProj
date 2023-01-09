namespace MediatorProj
{
    public interface IMessageWriter<T>
    {
        void WriteMessage(Message message);
    }
}