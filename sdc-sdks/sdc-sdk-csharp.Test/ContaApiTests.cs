using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Conductor.SDC.Client;
using Conductor.SDC.Api;
using Conductor.SDC.Model;

namespace Conductor.SDC.Test
{
    /// <summary>
    ///  Class for testing ContaApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ContaApiTests
    {
        private ContaApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new ContaApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContaApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ContaApi> (instance, "instance is a ContaApi");
        }

        
        /// <summary>
        /// Test CreateUsingPOST1
        /// </summary>
        [Test]
        public void CreateUsingPOST1Test()
        {
            // TODO: add unit test for the method 'CreateUsingPOST1'
            Conta conta = null; // TODO: replace null with proper value
            
            var response = instance.CreateUsingPOST1(conta);
            Assert.IsInstanceOf<Conta> (response, "response is Conta"); 
        }
        
        /// <summary>
        /// Test DeleteUsingDELETE
        /// </summary>
        [Test]
        public void DeleteUsingDELETETest()
        {
            // TODO: add unit test for the method 'DeleteUsingDELETE'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.DeleteUsingDELETE(id);
            Assert.IsInstanceOf<ResponseEntity> (response, "response is ResponseEntity"); 
        }
        
        /// <summary>
        /// Test GetAllUsingGET1
        /// </summary>
        [Test]
        public void GetAllUsingGET1Test()
        {
            // TODO: add unit test for the method 'GetAllUsingGET1'
            
            var response = instance.GetAllUsingGET1();
            Assert.IsInstanceOf<List<Conta>> (response, "response is List<Conta>"); 
        }
        
        /// <summary>
        /// Test GetOneUsingGET1
        /// </summary>
        [Test]
        public void GetOneUsingGET1Test()
        {
            // TODO: add unit test for the method 'GetOneUsingGET1'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetOneUsingGET1(id);
            Assert.IsInstanceOf<Conta> (response, "response is Conta"); 
        }
        
        /// <summary>
        /// Test UpdateUsingPUT1
        /// </summary>
        [Test]
        public void UpdateUsingPUT1Test()
        {
            // TODO: add unit test for the method 'UpdateUsingPUT1'
            Conta conta = null; // TODO: replace null with proper value
            
            var response = instance.UpdateUsingPUT1(conta);
            Assert.IsInstanceOf<Conta> (response, "response is Conta"); 
        }
        
    }

}