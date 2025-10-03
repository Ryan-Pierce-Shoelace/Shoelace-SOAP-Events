namespace Shoelace.Events
{
    public interface ISOEventListener<TValue>
    {
        void OnEventRaised(TValue item);
    }
}