// <copyright file="UserInputTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalogueProject;

namespace NetflixCatalogueProject.Tests
{
    /// <summary>This class contains parameterized unit tests for UserInput</summary>
    [PexClass(typeof(UserInput))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UserInputTest
    {

    }
}
