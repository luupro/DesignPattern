namespace DesignParttern.CreationalDP.Builder
{
    /// <summary>
    /// The builder interface specifies methods for creating the
    /// different parts of the product objects.
    /// </summary>
    public interface IBuilder
    {
        //method in interface have default modifier is public
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetTripComputer();
        void SetGPS();
    }
}
