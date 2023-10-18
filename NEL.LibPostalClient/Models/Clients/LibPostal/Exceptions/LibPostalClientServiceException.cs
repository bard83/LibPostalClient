﻿// ---------------------------------------------------------------
// Copyright (c) North East London ICB. All rights reserved.
// ---------------------------------------------------------------

using Xeptions;

namespace NEL.LibPostalClient.Models.Clients.LibPostal.Exceptions
{
    public class LibPostalClientServiceException : Xeption
    {
        public LibPostalClientServiceException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
