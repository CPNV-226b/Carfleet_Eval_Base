using System;
using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string _workZone;
        private Vehicle _vehicle = null;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, 
                      string emailaddress, string workZone, List<string> languages = null):
                      base(name, firstname, phonenumber, emailaddress, languages)
        {
            throw new NotImplementedException();
        }
        public string WorkZone { get => _workZone;}
        public Vehicle Vehicle
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void TakeAVehicle(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public void ReleaseAVehicle()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region embedded classes
        public class DriverException : Exception { }
        public class VehicleAlreadyAssignedException : DriverException { }
        public class NoVehicleAssignedException : DriverException { }
        #endregion embedded classes
    }
}
