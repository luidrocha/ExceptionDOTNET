using System;


namespace HotelReservaException.Exceptions
{
    class DomainException:ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
