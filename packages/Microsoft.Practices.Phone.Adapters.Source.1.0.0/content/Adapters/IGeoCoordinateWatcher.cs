﻿//===============================================================================
// Microsoft patterns & practices
// Building Testable Windows Phone Applications
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://wp7guide.codeplex.com/license)
//===============================================================================


using System;
using System.Device.Location;

namespace Microsoft.Practices.Phone.Adapters
{
    public interface IGeoCoordinateWatcher : IGeoPositionWatcher<GeoCoordinate>, IDisposable
    {
        GeoPositionAccuracy DesiredAccuracy { get; }
        double MovementThreshold { get; set; }
        GeoPositionPermission Permission { get; }
    }
}