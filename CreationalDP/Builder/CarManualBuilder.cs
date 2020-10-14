namespace DesignParttern.CreationalDP.Builder
{
    /// <summary>
    /// Unlike other creational patters, builder let you construct
    /// unrelated products that don't follow a common interface.
    /// </summary>
    class CarManualBuilder : IBuilder
    {
        private Manual manual;

        /// <summary>
        /// A fresh builder instance should contain a blank product
        /// object which it uses in further assembly.
        /// </summary>
        public CarManualBuilder()
        {
            Reset();
        }

        /// <summary>
        /// The reset method clears the object being build.
        /// </summary>
        public void Reset()
        {
            this.manual = new Manual();
        }

        // All production steps work with the same product instance

        /// <summary>
        /// Add engine instructions.
        /// </summary>
        public void SetEngine()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add engine instructions.
        /// </summary>
        public void SetGPS()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Document car seat features.
        /// </summary>
        public void SetSeats()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Add trip computer instructions.
        /// </summary>
        public void SetTripComputer()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Return the manual and reset the builder.
        /// </summary>
        /// <returns></returns>
        public Manual GetProduct()
        {
            var product = manual;
            this.Reset();
            return product;
        }
    }
}
