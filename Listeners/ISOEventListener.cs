namespace ShoelaceStudios.SOAP.Events
{
    public interface ISOEventListener<TValue>
    {
        void OnEventRaised(TValue item);
    }
}