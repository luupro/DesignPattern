namespace DesignParttern.CreationalDP.Builder
{
    /// <summary>
    /// The director is only responsible for executing the building
    /// steps in a particular sequence. It's helpfull when producing
    /// products according to a specific order or configuration.
    /// Strictly speaking, the director is optional, since the client can control builders directly
    /// 
    /// default modifier of class method is private
    /// </summary>
    class Director
    {
        private IBuilder builder;

        /// <summary>
        /// The director works with any buider instance that the
        /// client code passes to it. This way, the client code may
        /// alter the final type of the newly assembled product.
        /// </summary>
        /// <param name="builder"></param>
        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// The director can contruct several product variations
        /// using the same building steps.
        /// </summary>
        /// <param name="builder"></param>
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats();
            builder.SetEngine();
            builder.SetTripComputer();
            builder.SetGPS();
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats();
        }
    }
}
