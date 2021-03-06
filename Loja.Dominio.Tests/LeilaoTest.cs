// <copyright file="LeilaoTest.cs">Copyright ©  2017</copyright>
using System;
using System.Collections.Generic;
using Loja.Dominio;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loja.Dominio.Tests
{
    /// <summary>This class contains parameterized unit tests for Leilao</summary>
    [PexClass(typeof(Leilao))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class LeilaoTest
    {
        /// <summary>Test stub for Validar()</summary>
        [PexMethod]
        internal List<string> ValidarTest([PexAssumeUnderTest]Leilao target)
        {
            List<string> result = target.Validar();
            return result;
            // TODO: add assertions to method LeilaoTest.ValidarTest(Leilao)
        }
    }
}
