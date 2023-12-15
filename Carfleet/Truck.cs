using System;

namespace Carfleet{
    public class Truck:Vehicle
    {
        #region private attributes
        private Boolean _isCarryingGoods = false;
        #endregion private attributes

        #region public methods
        public Truck(string registration, string brand, string model, 
                     string chassisNumber):
                     base(registration, brand, model, chassisNumber)
        {
            throw new NotImplementedException();
        }

        public Boolean IsCarryingGoods
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
