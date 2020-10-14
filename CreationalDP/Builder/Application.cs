using System;
using System.Collections.Generic;
using System.Text;

namespace DesignParttern.CreationalDP.Builder
{
    class Application
    {
        public void MakeCar()
        {
            var director = new Director();

            CarBuilder builder = new CarBuilder();
            director.ConstructSportsCar(builder);
            Car car = builder.GetProduct();

            CarManualBuilder builder2 = new CarManualBuilder();
            director.ConstructSportsCar(builder2);

            // The final product is often retrieved from a builder
            // Object since the director isn't aware of and not
            // dependent on concreate builders and products.
            Manual manual = builder2.GetProduct();
        }
    }
}
