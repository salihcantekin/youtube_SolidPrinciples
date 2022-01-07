namespace SolidPrinciples.Lib
{
    public interface IMultipleEmailSendable
    {
        void SendTripIntoEmailToDrivers(List<DriverInfo> drivers);
    }
}