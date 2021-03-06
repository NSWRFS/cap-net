﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CAPNet.Models;
using Xunit;

namespace CAPNet.Tests.Models
{
    public class CoordinateTests
    {
        [Fact]
        public void CoordinatesAreParsedCorrectlyInRomanianLocale()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ro-RO");

            var coordinate = new Coordinate("38.47,-120.14");

            Assert.Equal(38.47, coordinate.Latitude);
        }
    }
}
