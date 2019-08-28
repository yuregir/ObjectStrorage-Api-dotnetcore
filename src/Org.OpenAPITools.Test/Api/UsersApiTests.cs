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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test Getusers
        /// </summary>
        [Fact]
        public void GetusersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string where = null;
            //string sort = null;
            //int? page = null;
            //int? maxResults = null;
            //var response = instance.Getusers(where, sort, page, maxResults);
            //Assert.IsType<InlineResponse20015> (response, "response is InlineResponse20015");
        }
        
        /// <summary>
        /// Test GetusersItem
        /// </summary>
        [Fact]
        public void GetusersItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usersId = null;
            //var response = instance.GetusersItem(usersId);
            //Assert.IsType<Users> (response, "response is Users");
        }
        
        /// <summary>
        /// Test PatchusersItem
        /// </summary>
        [Fact]
        public void PatchusersItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usersId = null;
            //string ifMatch = null;
            //Users users = null;
            //instance.PatchusersItem(usersId, ifMatch, users);
            
        }
        
        /// <summary>
        /// Test Postusers
        /// </summary>
        [Fact]
        public void PostusersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Users users = null;
            //instance.Postusers(users);
            
        }
        
        /// <summary>
        /// Test PutusersItem
        /// </summary>
        [Fact]
        public void PutusersItemTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string usersId = null;
            //string ifMatch = null;
            //Users users = null;
            //instance.PutusersItem(usersId, ifMatch, users);
            
        }
        
    }

}