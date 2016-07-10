using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Conductor.SDC.Api;
using Conductor.SDC.Model;
using Conductor.SDC.Client;
using System.Reflection;

namespace Conductor.SDC.Test
{
    /// <summary>
    ///  Class for testing Transacao
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TransacaoTests
    {
        private Transacao instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Transacao();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Transacao
        /// </summary>
        [Test]
        public void TransacaoInstanceTest()
        {
            Assert.IsInstanceOf<Transacao> (instance, "instance is a Transacao");
        }

        
        /// <summary>
        /// Test the property 'DataTransacao' 
        /// </summary>
        [Test]
        public void DataTransacaoTest()
        {
            // TODO: unit test for the property 'DataTransacao' 
        }
        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Msg' 
        /// </summary>
        [Test]
        public void MsgTest()
        {
            // TODO: unit test for the property 'Msg' 
        }
        
        /// <summary>
        /// Test the property 'Valor' 
        /// </summary>
        [Test]
        public void ValorTest()
        {
            // TODO: unit test for the property 'Valor' 
        }
        

    }

}
