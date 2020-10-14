namespace DesignParttern.CreationalDP.Builder
{
    /// <summary>
    /// The concrete builder classes follow the builder interface and
    /// provide specific implementations of the building steps. Your
    /// program may have several variations of builders, each
    /// implemented differently
    /// </summary>
    class CarBuilder : IBuilder
    {
        private Car car;

        /// <summary>
        /// A fresh builder instance should contain a blank product
        /// object which it uses in further assembly.
        /// </summary>
        public CarBuilder()
        {
            Reset();
        }

        /// <summary>
        /// The reset method clears the object being build.
        /// </summary>
        public void Reset()
        {
            this.car = new Car();
        }

        // All production steps work with the same product instance

        /// <summary>
        /// Install a given engine.
        /// </summary>
        public void SetEngine()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Install a global positioning system.
        /// </summary>
        public void SetGPS()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Set the number of seats in the car.
        /// </summary>
        public void SetSeats()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Install a trip computer.
        /// </summary>
        public void SetTripComputer()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Concrete builders are supposed to provide their own
        /// methods for retrieving results. That's because various
        /// types of builders may create entirely different products
        /// that don't all follow the same interface. Therefore such
        /// methods can't be declared in the builder interface (at
        /// least not in a statically-typed programming language).
        /// 
        /// Usually, after running the end result to the client, a
        /// builder instance is expected to be ready to start
        /// producing another product. That's why it's usual
        /// practice to call the reset method at the end of the
        /// `getProduct` method body. However, this behavior isn't
        /// mandatory, and you can make your builder wait for an
        /// explicit reset call from client code before disposing
        /// of the previous result.
        /// </summary>
        /// <returns></returns>
        public Car GetProduct()
        {
            var product = car;
            this.Reset();
            return product;
        }
    }
}
