/* 
 * Metacore IOT Object Storage API
 *
 * Metacore IOT Core Services
 *
 * The version of the OpenAPI document: 0.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing RolesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RolesApiTests : IDisposable
    {
        private RolesApi instance;

        public RolesApiTests()
        {
            instance = new RolesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RolesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RolesApi
            //Assert.IsType(typeof(RolesApi), instance, "instance is a RolesApi");
        }

        
        /// <summary>
        /// Test Getroles
        /// </summary>
        [Fact]
        public void GetrolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //string sort = null;
            //int? page = null;
            //int? maxResults = null;
            //var response = instance.Getroles(where, sort, page, maxResults);
            //Assert.IsType<InlineResponse20011> (response, "response is InlineResponse20011");
        }
        
        /// <summary>
        /// Test GetrolesItem
        /// </summary>
        [Fact]
        public void GetrolesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rolesId = null;
            //var response = instance.GetrolesItem(rolesId);
            //Assert.IsType<Roles> (response, "response is Roles");
        }
        
        /// <summary>
        /// Test PatchrolesItem
        /// </summary>
        [Fact]
        public void PatchrolesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rolesId = null;
            //string ifMatch = null;
            //Roles roles = null;
            //instance.PatchrolesItem(rolesId, ifMatch, roles);
            
        }
        
        /// <summary>
        /// Test Postroles
        /// </summary>
        [Fact]
        public void PostrolesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Roles roles = null;
            //instance.Postroles(roles);
            
        }
        
        /// <summary>
        /// Test PutrolesItem
        /// </summary>
        [Fact]
        public void PutrolesItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string rolesId = null;
            //string ifMatch = null;
            //Roles roles = null;
            //instance.PutrolesItem(rolesId, ifMatch, roles);
            
        }
        
    }

}